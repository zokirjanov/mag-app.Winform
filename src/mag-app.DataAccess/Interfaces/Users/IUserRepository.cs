using mag_app.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.DataAccess.Interfaces.Users
{
	public interface IUserRepository
	{
		public Task<User?> FindByIdAsync(long id);

		public Task<User?> FirstOrDefaultAsync(Expression<Func<User, bool>> expression);

		public void Add(User entity);

		public void Delete(long id);

		public void Update(long id, User entity);

		public Task<int> SaveChangesAsync();
	}
}
