using mag_app.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.DataAccess.Interfaces
{
    public interface IGenericRepository<T>  where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression = null!);

        public Task<IQueryable<T>> Where(Expression<Func<T, bool>> expression);

        public Task<T?> FindByIdAsync(long id);

        public Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression);

        public Task<T> CreateAsync(T entity);

        public Task<bool> DeleteAsync(Expression<Func<T, bool>> expression);

        public Task<T> UpdateAsync(T entity);
    }
}
