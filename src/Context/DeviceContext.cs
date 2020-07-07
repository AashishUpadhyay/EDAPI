using EDAPI.Controllers;
using EDAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDAPI.Context
{
	public class DeviceContext : DbContext
	{
		public DbSet<Device> Devices { get; set; }

		public DeviceContext(DbContextOptions<DeviceContext> options) : base(options)
		{
			Database.EnsureCreated();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			for (int i = 3; i <= 100; i += 3)
			{
				modelBuilder.Entity<Device>().HasData(
				new Device()
				{
					Id = (i + 1),
					DeviceName = "IPhone" + "_" + (i + 1),
					Make = "Apple"
				},
				new Device()
				{
					Id = (i + 2),
					DeviceName = "Apple Watch" + "_" + (i + 2),
					Make = "Apple"
				},
				new Device()
				{
					Id = (i + 3),
					DeviceName = "Macbook" + "_" + (i + 3),
					Make = "Apple"
				});
			}

			base.OnModelCreating(modelBuilder);
		}
	}
}
