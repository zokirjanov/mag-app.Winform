using mag_app.Domain.Entities.Users;
using mag_app.Service.Common.Helpers;

namespace mag_app.Service.Dtos.Accounts
{
	public class RegisterViewModel
	{
		public string Login { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;
		public static implicit operator User(RegisterViewModel accountRegisterDto)
		{
			return new User()
			{
				Login = accountRegisterDto.Login,
				Email = accountRegisterDto.Email,
			};

		}
	}
}
