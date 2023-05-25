

using CQRS.Query;

namespace OfficeEquipment.Application.Device.Get
{
	public class GetQuery : IQuery<Domain.Entities.Order>
	{
		public GetQuery(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
	}
}
