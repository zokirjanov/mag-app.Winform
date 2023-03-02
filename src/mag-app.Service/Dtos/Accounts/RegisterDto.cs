using mag_app.Domain.Entities.Users;
using mag_app.Service.Common.Helpers;

namespace mag_app.Service.Dtos.Accounts
{
	public class RegisterDto
	{
		public string Login { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;
		public static implicit operator User(RegisterDto accountRegisterDto)
		{
			return new User()
			{
				Login = accountRegisterDto.Login,
				Email = accountRegisterDto.Email,
				CreatedAt = TimeHelper.CurrentTime(),
				UpdatedAt = TimeHelper.CurrentTime(),
			};

		}
	}
}
