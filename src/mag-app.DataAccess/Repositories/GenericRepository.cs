using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces;
using mag_app.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.DataAccess.Repositories
{
    public class GenericRepository<T> : BaseRepository<T>, IGenericRepository<T> where T : BaseEntity
    {
        public GenericRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public IQueryable<T> GetAll() => _dbSet;

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
            => _dbSet.Where(expression);
    }
}
