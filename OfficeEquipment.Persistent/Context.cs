using Microsoft.EntityFrameworkCore;
using OfficeEquipment.Application.Interfaces;
using OfficeEquipment.Domain.Entities;

namespace OfficeEquipment.Persistent
{
	public class Context : DbContext, IContext
	{
		public Context()
		{

			_ = base.Database.EnsureCreated();
		}
		public DbSet<User> Users { get; set; }
		public DbSet<Device> Devices { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Role> Roles { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			_ = optionsBuilder.UseSqlite("DataSource=DataBase.db");
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
