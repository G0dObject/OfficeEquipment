using CQRS.Command;
using OfficeEquipment.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace OfficeEquipment.Application.Authentication.Register
{
	public class RegisterCommand : ICommand<int>
	{
		public RegisterCommand(string? login, string? password, Role role)
		{
			Login = login;
			Password = password;
			Role = role;
		}
		[Required]
		public string? Login { get; set; }
		[Required]
		public string? Password { get; set; }

		public Role Role { get; set; }

	}
}
