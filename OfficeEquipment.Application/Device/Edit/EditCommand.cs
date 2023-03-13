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
		public string Characteristics { get; set; } = string.Empty;
		public string Type { get; set; } = string.Empty;
		public string Code { get; set; } = string.Empty;
		public string NameInNet { get; set; } = string.Empty;
		public string IPAdress { get; set; } = string.Empty;
		public string Provider { get; set; } = string.Empty;
		public int EmployeeId { get; set; }
		public int DepartmentId { get; set; }
	}
}
