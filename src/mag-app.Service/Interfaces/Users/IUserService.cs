using mag_app.Service.Dtos.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Interfaces.Users
{
	public interface IUserService
	{
		public Task<string> AccountLoginAsync(LoginViewModel LoginDto);
		public void AccountLogout();
		public Task<string> AccountRegisterAsync(RegisterViewModel RegisterDto);
		public Task<string> AccountRememberMeAsync(LoginViewModel LoginDto);
	}
}
