using mag_app.Domain.Entities.Products;
using mag_app.Service.Interfaces.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Services.ProductService
{
    public class ProductService : IproductService
    {
        public Task<bool> CreateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(long id, Product Product)
        {
            throw new NotImplementedException();
        }
    }
}
