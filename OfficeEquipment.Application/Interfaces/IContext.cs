using Microsoft.EntityFrameworkCore;
using OfficeEquipment.Domain.Entities;
using System.Collections.Generic;

namespace OfficeEquipment.Application.Interfaces
{
	public interface IContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Role> Roles { get; set; }

		public Task<int> SaveChangesAsync(CancellationToken cancellationToken);


	}
}
