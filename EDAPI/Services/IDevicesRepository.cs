using EDAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDAPI.Services
{
	public interface IDevicesRepository
	{
		IQueryable<Device> GetDevices();

		Device GetDevice(int deviceId);
	}
}
