using CQRS.Command;
using Microsoft.EntityFrameworkCore;
using OfficeEquipment.Application.Interfaces;
using OfficeEquipment.Domain.Entities;

namespace OfficeEquipment.Application.Device.Edit
{
	public class EditCommandHandler : ICommandHandler<EditCommand, int>
	{
		private IContext _context;
		public EditCommandHandler(IContext context) => _context = context;

		public async Task<int> Handle(EditCommand request)
		{
			Domain.Entities.Device? obj = await _context.Devices.Include(f => f.Department).Include(f => f.Employee).SingleOrDefaultAsync(f => f.Id == request.Id);

			obj.Name = request.Name;
			obj.Characteristics = request.Characteristics;
			obj.Type = request.Type;
			obj.Code = request.Code;
			obj.NameInNet = request.NameInNet;
			obj.IPAdress = request.IPAdress;
			obj.Provider = request.Provider;
			obj.Department = await _context.Departments.SingleOrDefaultAsync(f => f.Id == request.DepartmentId) ?? new Department() { Name = "New department" };
			obj.Employee = await _context.Employees.SingleOrDefaultAsync(f => f.Id == request.EmployeeId) ?? new Employee() { Name = "New employee" };
			_context.Devices.Update(obj);
			await _context.SaveChangesAsync(new CancellationToken());
			return 0;

		}
	}
}
