using CQRS.Command;
using Microsoft.EntityFrameworkCore;
using OfficeEquipment.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeEquipment.Application.Device.Delete
{
	public class DeleteCommandHandler : ICommandHandler<DeleteCommand, int>
	{
		private IContext _context;
		public DeleteCommandHandler(IContext context) => _context = context;

		public async Task<int> Handle(DeleteCommand request)
		{
			_context.Orders.Remove(await _context.Orders.SingleOrDefaultAsync(f => f.Id == request.Id));
			await _context.SaveChangesAsync(new CancellationToken());
			return 0;
		}
	}
}
