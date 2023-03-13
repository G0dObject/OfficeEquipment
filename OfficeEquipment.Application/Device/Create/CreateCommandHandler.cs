using CQRS.Command;
using Microsoft.EntityFrameworkCore;
using OfficeEquipment.Application.Interfaces;
using OfficeEquipment.Domain.Entities;

namespace OfficeEquipment.Application.Device.Create
{
	public class CreateCommandHandler : ICommandHandler<CreateCommand, int>
	{
		private readonly IContext _context;
		public CreateCommandHandler(IContext context)
		{
			_context = context;
		}
		public async Task<int> Handle(CreateCommand request)
		{
			Domain.Entities.Device device = new Domain.Entities.Device(request.Name, request.Characteristics, request.Type, request.Code, request.NameInNet, request.IPAdress, request.Provider);
			device.Department = await _context.Departments.SingleOrDefaultAsync(f => f.Id == request.DepartmentId) ?? new Department() { Name = "New department" };
			device.Employee = await _context.Employees.SingleOrDefaultAsync(f => f.Id == request.EmployeeId) ?? new Employee() { Name = "New employee" };
			await _context.Devices.AddAsync(device);
			await _context.SaveChangesAsync(new CancellationToken());
			return 0;
		}
	}
}
