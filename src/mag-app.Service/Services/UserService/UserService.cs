using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Users;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Accounts;
using mag_app.Service.Interfaces.Users;
using mag_app.Service.Security;
using Microsoft.EntityFrameworkCore;

namespace mag_app.Service.Services.UserService
{
    public class UserService : IUserService
    {
        private AppDbContext _appDbContext;
        public UserService(AppDbContext appContext)
        {
            _appDbContext = appContext;
        }

        public async Task<string> AccountLoginAsync(LoginViewModel LoginDto)
        {
            var user = await _appDbContext.Users.FirstOrDefaultAsync(
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
            var path = Environment.CurrentDirectory + "Rememberme.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public async Task<string> AccountRegisterAsync(RegisterViewModel RegisterDto)
        {
            var account = await _appDbContext.Users.FirstOrDefaultAsync(
            x => x.Login.ToLower() == RegisterDto.Login.ToLower());
            if (account != null) { return "User already exists"; }
            var user = (User)RegisterDto;
            var hash = PasswordHasher.Hash(RegisterDto.Password);
            user.PasswordHash = hash.Hash;
            user.Salt = hash.Salt;
            _appDbContext.Users.Add(user);
            var res = await _appDbContext.SaveChangesAsync();
            if (res > 0) return "true";
            return "false";
        }

        public async Task<string> AccountRememberMeAsync(LoginViewModel LoginDto)
        {
            var user = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Login.ToLower() == LoginDto.Login.ToLower());
            if (user is null) { return "User not Found"; }
            string path = "database.txt";
            File.WriteAllText(path, LoginDto.Login + ":" + LoginDto.Password);
            return "true";
        }
    }
}
