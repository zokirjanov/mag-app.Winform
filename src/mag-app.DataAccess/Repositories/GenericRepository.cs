using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces;
using mag_app.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace mag_app.DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected AppDbContext _dbcontext;
        protected DbSet<T> _dbSet;
        public GenericRepository()
        { 
            _dbcontext = new AppDbContext();
            _dbSet = _dbcontext.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression = null!)
        {
            return expression == null ? _dbSet : _dbSet.Where(expression);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.FirstOrDefaultAsync(expression);
        }

        public async Task<IQueryable<T>> Where(Expression<Func<T, bool>> expression)
            =>  _dbSet.Where(expression);
     

        public async Task<T>  CreateAsync(T entity)
        {
            var res = await _dbSet.AddAsync(entity);
            await _dbcontext.SaveChangesAsync();
            return res.Entity;
        }


        public  async Task<T?> FindByIdAsync(long id)
        {
            return await _dbSet.FindAsync(id);
        }

        public  async Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.FirstOrDefaultAsync(expression);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var updatedEntity = _dbSet.Update(entity);

            await _dbcontext.SaveChangesAsync();

            return updatedEntity.Entity;
        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> expression)
        {
            var entity = _dbSet.FirstOrDefault(expression);
            if (entity == null)  return false;
             _dbSet.Remove(entity);
            var res = await _dbcontext.SaveChangesAsync();
            return(res >= 1)? true: false;
        }
    }
}
