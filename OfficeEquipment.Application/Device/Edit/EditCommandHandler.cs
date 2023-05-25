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
			Domain.Entities.Order? obj = await _context.Orders.SingleOrDefaultAsync(f => f.Id == request.Id);

			obj.Name = request.Name;
			obj.Breaking = request.Breaking;
			obj.Code = request.Code;
			obj.Details = request.Details;
			obj.Type = request.Type;


			_context.Orders.Update(obj);
			await _context.SaveChangesAsync(new CancellationToken());
			return 0;

		}
	}
}
