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
			modelBuilder.Entity<Device>().HasData(
				new Device()
				{
					Id = 1,
					DeviceName = "IPhone",
					Make = "Apple"
				},
				new Device()
				{
					Id = 2,
					DeviceName = "Apple Watch",
					Make = "Apple"
				},
				new Device()
				{
					Id = 3,
					DeviceName = "Macbook",
					Make = "Apple"
				});
			base.OnModelCreating(modelBuilder);
		}
	}
}
