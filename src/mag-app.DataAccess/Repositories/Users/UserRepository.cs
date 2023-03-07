using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces.Users;
using mag_app.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.DataAccess.Repositories.Users
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }
        //private AppDbContext _dbContext;
        //private DbSet<User> _dbSet;

        //public UserRepository(AppDbContext appDbContext)
        //{
        //    _dbContext = appDbContext;
        //    _dbSet = appDbContext.Set<User>();
        //}


        //public void Add(User entity) => _dbSet.Add(entity);

        //public void Delete(long id)
        //{
        //    var entity = _dbSet.Find(id);
        //    if (entity is not null)
        //        _dbSet.Remove(entity);
        //}

        //public async Task<User?> FindByIdAsync(long id)
        //{
        //    return await _dbSet.FindAsync(id);
        //}

        //public async Task<User?> FirstOrDefaultAsync(Expression<Func<User, bool>> expression)
        //{
        //    return await _dbSet.FirstOrDefaultAsync(expression);
        //}

        //public void Update(long id, User entity)
        //{
        //    entity.Id = id;
        //    _dbSet.Update(entity);
        //}
        //public async Task<int> SaveChangesAsync()
        //{
        //    return await _dbContext.SaveChangesAsync();
        //}

    }
}
