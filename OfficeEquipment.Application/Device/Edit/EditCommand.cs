using CQRS.Command;

namespace OfficeEquipment.Application.Device.Edit
{
	public class EditCommand : ICommand<int>
	{
		public EditCommand(int id)
		{
			Id = id;
		}
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Breaking { get; set; } = string.Empty;
		public string Type { get; set; } = string.Empty;
		public string Code { get; set; } = string.Empty;
		public string Details { get; set; } = string.Empty;
	}
}
