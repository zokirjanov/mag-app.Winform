using mag_app.DataAccess.Interfaces.Stores;
using mag_app.Domain.Entities.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.DataAccess.Repositories.Stores
{
    public class TabProductRepository : GenericRepository<TabProduct>, ITabProductRepository
    {
    }
}

