using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.DataAccess.Interfaces.Users
{
	public interface IUserRepository : IGenericRepository<User>
	{ 
	}
}
