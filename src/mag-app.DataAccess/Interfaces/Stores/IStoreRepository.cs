using mag_app.Domain.Entities.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.DataAccess.Interfaces.Stores
{
    public interface IStoreRepository : IGenericRepository<Store>
    {
        //public Task<Store?> FindByIdAsync(long id);

        //public Task<Store?> FirstOrDefaultAsync(Expression<Func<Store, bool>> expression);

        //public void Add(Store entity);
            
        //public void Delete(long id);

        //public void Update(long id, Store entity);

        //public Task<int> SaveChangesAsync();
    }
}
