using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EDAPI.Models;
using EDAPI.Services;
using Microsoft.AspNetCore.Mvc;
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
	}
}
