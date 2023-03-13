
using System.ComponentModel;


namespace OfficeEquipment.Model
{
	internal class AuthorizationModel : IDataErrorInfo
	{
		public string UserName { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;
		public string PasswordConfirm { get; set; } = string.Empty;

		public string Error { get; private set; } = string.Empty;

		public string this[string columnName]
		{
			get
			{
				Error = string.Empty;
				switch (columnName)
				{
					case "UserName":
						if (UserName!.Length < 5 || UserName == null)
						{
							Error = "Логин должен содержать не менее 5 символов";
						}
						break;

					case "Password":
						if (Password!.Length < 5 || columnName == null)
						{
							Error = "Пароль должен содержать не менее 5 символов";
						}
						break;
					case "PasswordConfirm":
						if (PasswordConfirm != Password || Password!.Length < 5 || columnName == null)
						{
							Error = "Пароли не совпадают";
						}
						break;

					default:
						break;
				}
				return Error;
			}
		}
	}
}
