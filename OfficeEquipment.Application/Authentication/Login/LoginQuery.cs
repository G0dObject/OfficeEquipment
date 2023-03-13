using CQRS.Query;
using System.ComponentModel.DataAnnotations;

namespace OfficeEquipment.Application.Authentication.Login
{
	public class LoginQuery : IQuery<int>
	{
		public LoginQuery(string? login, string? password)
		{
			Login = login;
			Password = password;
		}
		public LoginQuery()
		{

		}
		[Required]
		public string? Login { get; set; }
		[Required]
		public string? Password { get; set; }
	}
}
