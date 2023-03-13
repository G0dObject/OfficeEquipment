namespace OfficeEquipment.Domain.Entities
{
	public class Device : IBaseEnitity
	{
		public Device(string name, string characteristics, string type, string code, string nameInNet, string iPAdress, string provider)
		{

			Name = name;
			Characteristics = characteristics;
			Type = type;
			Code = code;
			NameInNet = nameInNet;
			IPAdress = iPAdress;
			Provider = provider;

		}

		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Characteristics { get; set; } = string.Empty;
		public string Type { get; set; } = string.Empty;
		public string Code { get; set; } = string.Empty;
		public string NameInNet { get; set; } = string.Empty;
		public string IPAdress { get; set; } = string.Empty;
		public string Provider { get; set; } = string.Empty;
		public Employee? Employee { get; set; }
		public Department? Department { get; set; }
	}
}
