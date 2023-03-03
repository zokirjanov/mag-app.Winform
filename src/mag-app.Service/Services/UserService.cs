using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Users;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Accounts;
using mag_app.Service.Interfaces.Users;
using mag_app.Service.Security;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Service
{
	public class UserService : IUserService
	{
		private AppDbContext _repository;
		public UserService(AppDbContext appContext)
		{
			_repository = appContext;
		}

		public async Task<string> AccountLoginAsync(LoginDto LoginDto)
		{
			var user = await _repository.Users.FirstOrDefaultAsync(
			x => x.Login.ToLower() == LoginDto.Login.ToLower());
			if (user is null) { return "User not Found"; }
			var checkPass = PasswordHasher.Verify(LoginDto.Password, user.Salt, user.PasswordHash);
			if (checkPass)
			{
                IdentitySingelton.BuildInstance(user.Id);
                return true.ToString();
			}
			return "Password wrong";
		}

		public void AccountLogout()
		{
			var path = Environment.CurrentDirectory + "\\Rememberme.txt";
			if (File.Exists(path))
			{
				File.Delete(path);

			}
		}

		public  async Task<string> AccountRegisterAsync(RegisterDto RegisterDto)
		{
			var account = await _repository.Users.FirstOrDefaultAsync(
		    x => x.Login.ToLower() == RegisterDto.Login.ToLower());
			if (account != null) { return "User already exists";}
			var user = (User)RegisterDto;
			var hash = PasswordHasher.Hash(RegisterDto.Password);
			user.PasswordHash = hash.Hash;
			user.Salt = hash.Salt;
			_repository.Users.Add(user);
			var res = await _repository.SaveChangesAsync();
			if (res > 0) return "true";
			return "false";
		}

		public async Task<string> AccountRememberMeAsync(LoginDto LoginDto)
		{
			var user = await _repository.Users.FirstOrDefaultAsync(x => x.Login.ToLower() == LoginDto.Login.ToLower());
			if (user is null) { return "User not Found"; }
            string path = "database.txt";
            File.WriteAllText(path, LoginDto.Login + ":" + LoginDto.Password);
			return "true";
		}
	}
}
