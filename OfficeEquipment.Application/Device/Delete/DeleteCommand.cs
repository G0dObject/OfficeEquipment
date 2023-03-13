using CQRS.Command;



namespace OfficeEquipment.Application.Device.Delete
{
	public class DeleteCommand : ICommand<int>
	{
		public int Id { get; set; }
	}
}
