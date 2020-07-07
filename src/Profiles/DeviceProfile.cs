using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDAPI.Profiles
{
	public class DeviceProfile: Profile
	{
		public DeviceProfile()
		{
			CreateMap<Entities.Device, Models.Device>();
		}
	}
}
