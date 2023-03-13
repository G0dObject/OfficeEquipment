using CQRS.Query;
using Microsoft.EntityFrameworkCore;
using OfficeEquipment.Application.Interfaces;

namespace OfficeEquipment.Application.Device.Get
{
	public class GetQueryHandler : IQueryHandler<GetQuery, Domain.Entities.Device>
	{
		private IContext _context;
		public GetQueryHandler(IContext context) => _context = context;

		public async Task<Domain.Entities.Device> Handle(GetQuery request)
		{
			return await _context.Devices.Include(f => f.Department).Include(f => f.Employee).SingleOrDefaultAsync(f => f.Id == request.Id);
		}
	}
}
