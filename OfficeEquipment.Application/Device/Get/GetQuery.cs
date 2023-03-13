

using CQRS.Query;

namespace OfficeEquipment.Application.Device.Get
{
	public class GetQuery : IQuery<Domain.Entities.Device>
	{
		public GetQuery(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
	}
}
