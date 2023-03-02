using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces.Stores;
using mag_app.Domain.Entities.Stores;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.DataAccess.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private AppDbContext _dbContext;
        private DbSet<Store> _dbSet;

        public StoreRepository(AppDbContext dbContext, DbSet<Store> dbSet)
        {
            _dbContext = dbContext;
            _dbSet = dbSet;
        }
        public void Add(Store entity) => _dbSet.Add(entity);
        public void Delete(long id)
        {
            var entity = _dbSet.Find(id);
            if (entity is not null)  _dbSet.Remove(entity);
        }

        public async Task<Store?> FindByIdAsync(long id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<Store?> FirstOrDefaultAsync(Expression<Func<Store, bool>> expression)
        {
            return await _dbSet.FirstOrDefaultAsync(expression);
        }

        public void Update(long id, Store entity)
        {
            entity.Id = id;
            _dbSet.Update(entity);
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
