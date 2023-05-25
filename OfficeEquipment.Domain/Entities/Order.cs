namespace OfficeEquipment.Domain.Entities
{
	public class Order : IBaseEnitity
	{
		public Order(int id, string name, string breaking, string type, string code, string details)
		{
			Id = id;
			Name = name;
			Breaking = breaking;
			Type = type;
			Code = code;
			Details = details;
		}

		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Breaking { get; set; } = string.Empty;
		public string Type { get; set; } = string.Empty;
		public string Code { get; set; } = string.Empty;
		public string Details { get; set; } = string.Empty;
	}
}
