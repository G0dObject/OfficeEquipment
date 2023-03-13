namespace OfficeEquipment.Domain.Entities
{
	public class Role : IBaseEnitity
	{
		public string? Name { get; set; }
		public virtual ICollection<User>? Users { get; set; }
		public int Id { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}
