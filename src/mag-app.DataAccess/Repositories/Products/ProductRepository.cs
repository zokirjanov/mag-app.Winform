using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces;
using mag_app.DataAccess.Interfaces.Products;
using mag_app.Domain.Entities.Products;
using System.Linq.Expressions;

namespace mag_app.DataAccess.Repositories.Products
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
    }
}
