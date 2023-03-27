using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces.AllProducts;
using mag_app.DataAccess.Interfaces.Products;
using mag_app.Domain.Entities.AllProducts;
using mag_app.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.DataAccess.Repositories.AllProducts
{
    public class AllProductRepository : GenericRepository<AllProduct>, IAllProductRepository
    {
        public AllProductRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
