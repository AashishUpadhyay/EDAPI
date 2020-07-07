using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EDAPI.Models;
using EDAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace EDAPI.Controllers
{
	[ApiController]
	[Route("api/devices")]
	public class DevicesController : ControllerBase
	{
		private readonly IDevicesRepository _devicesRepository;
		private readonly IMapper _mapper;

		public DevicesController(IDevicesRepository devicesRepository, IMapper mapper)
		{
			_devicesRepository = devicesRepository;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult GetDevices()
		{
			var devices = _devicesRepository.GetDevices();
			return Ok(_mapper.Map<IEnumerable<Device>>(_devicesRepository.GetDevices()));
		}

		[HttpGet("{id}")]
		public IActionResult GetDevice(int id)
		{
			var device = _devicesRepository.GetDevice(id);
			if (device == null)
				return NotFound();
			return Ok(_mapper.Map<Device>(device));
		}

		[HttpPost]
		[Route("search")]
		public IActionResult Search(SearchRequest searchRequest)
		{
			var filteredDevices = FilterDevices(searchRequest);
			HashSet<string> fields = null;
			if ((searchRequest.Fields != null && searchRequest.Fields.Count > 0))
				fields = searchRequest.Fields.ToHashSet();

			var returnValue = new Dictionary<string, Content>();
			foreach (var pfd in filteredDevices)
			{
				AddFieldToResult(pfd.Id.ToString(), fields, nameof(pfd.DeviceName), pfd.DeviceName, "Text" ,returnValue);
				AddFieldToResult(pfd.Id.ToString(), fields, nameof(pfd.Make), pfd.DeviceName, "Text", returnValue);
			}

			return Ok(returnValue.Values);
		}

		private IEnumerable<Device> FilterDevices(SearchRequest searchRequest)
		{
			int skip = 0;
			int top = 100;

			if (searchRequest.Skip > 0)
				skip = searchRequest.Skip;

			if (searchRequest.Top > 0)
				top = searchRequest.Top;

			var filteredDevices = new List<Device>();
			var devices = _devicesRepository.GetDevices();
			if (searchRequest.ContentIds != null && searchRequest.ContentIds.Count > 0)
			{
				var contentIds = searchRequest.ContentIds.ToHashSet();
				filteredDevices = _mapper.Map<IEnumerable<Device>>(devices.Where(u => contentIds.Contains(u.Id.ToString()))).ToList();
			}
			else
				filteredDevices = _mapper.Map<IEnumerable<Device>>(devices).ToList();

			return filteredDevices.Skip(skip).Take(top);
		}

		private void AddFieldToResult(string contentId, HashSet<string> fields, string fieldName, string fieldValue, string fieldType, Dictionary<string, Content> returnValue)
		{
			if (fields != null)
			{
				if (fields.Contains(fieldName))
				{
					if (!returnValue.ContainsKey(contentId))
						returnValue.Add(contentId, new Content()
						{
							ContentId = contentId,
							Fields = new List<ContentField>()
						});

					returnValue[contentId].Fields.Add(new ContentField()
					{
						FieldName = fieldName,
						FieldValue = fieldValue,
						FieldType = fieldType
					});
				}
			}
			else
			{
				if (!returnValue.ContainsKey(contentId))
					returnValue.Add(contentId, new Content()
					{
						ContentId = contentId,
						Fields = new List<ContentField>()
					});

				returnValue[contentId].Fields.Add(new ContentField()
				{
					FieldName = fieldName,
					FieldValue = fieldValue,
					FieldType = fieldType
				});
			}
		}
	}

	public class SearchRequest
	{
		public int Skip { get; set; }
		public int Top { get; set; }
		public IList<string> Fields { get; set; }
		public IList<string> ContentIds { get; set; }
	}

	public class Content
	{
		public string ContentId { get; set; }

		public IList<ContentField> Fields { get; set; }
	}

	public class ContentField
	{
		public string FieldName { get; set; }
		public string FieldType { get; set; }
		public object FieldValue { get; set; }
	}
}
