using EDAPI.Context;
using EDAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDAPI.Services
{
	public class DevicesRepository : IDevicesRepository
	{
		private readonly DeviceContext _deviceContext;

		public DevicesRepository(DeviceContext deviceContext)
		{
			_deviceContext = deviceContext ?? throw new ArgumentNullException(nameof(deviceContext));
		}

		public Device GetDevice(int deviceId)
		{
			return _deviceContext.Devices.Where(u => u.Id == deviceId).FirstOrDefault();
		}

		public IQueryable<Device> GetDevices()
		{
			return _deviceContext.Devices;
		}

		public bool Save()
		{
			return (_deviceContext.SaveChanges() >= 0);
		}
	}
}
