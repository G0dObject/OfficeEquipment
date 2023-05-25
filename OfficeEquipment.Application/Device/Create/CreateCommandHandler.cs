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
			Domain.Entities.Order device = new Order(request.Id, request.Name, request.Breaking, request.Type, request.Code, request.Details);
			await _context.Orders.AddAsync(device);
			await _context.SaveChangesAsync(new CancellationToken());
			return 0;
		}
	}
}
