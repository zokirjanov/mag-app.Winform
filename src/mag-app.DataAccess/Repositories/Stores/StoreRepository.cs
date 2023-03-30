using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces.Stores;
using mag_app.Domain.Entities.Stores;

namespace mag_app.DataAccess.Repositories.Stores
{
    public class StoreRepository : GenericRepository<Store>, IStoreRepository
    {
    }
}
