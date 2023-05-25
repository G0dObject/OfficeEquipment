using CQRS.Query;
using Microsoft.EntityFrameworkCore;
using OfficeEquipment.Application.Interfaces;

namespace OfficeEquipment.Application.Device.Get
{
	public class GetQueryHandler : IQueryHandler<GetQuery, Domain.Entities.Order>
	{
		private IContext _context;
		public GetQueryHandler(IContext context) => _context = context;

		public async Task<Domain.Entities.Order> Handle(GetQuery request)
		{
			return await _context.Orders.SingleOrDefaultAsync(f => f.Id == request.Id);
		}
	}
}
