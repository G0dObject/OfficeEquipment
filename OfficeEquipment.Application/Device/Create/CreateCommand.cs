using CQRS.Command;
using OfficeEquipment.Domain.Entities;

namespace OfficeEquipment.Application.Device.Create
{
	public class CreateCommand : ICommand<int>
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Breaking { get; set; } = string.Empty;
		public string Type { get; set; } = string.Empty;
		public string Code { get; set; } = string.Empty;
		public string Details { get; set; } = string.Empty;
	}
}
