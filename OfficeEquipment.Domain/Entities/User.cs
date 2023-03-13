﻿namespace OfficeEquipment.Domain.Entities
{
	public class User : IBaseEnitity
	{
		public int Id { get; set; }
		public string Login { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;
		public Role Role { get; set; }


	}
}
