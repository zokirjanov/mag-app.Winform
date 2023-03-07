using mag_app.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Interfaces.Products
{
    public interface IproductService
    {
        public Task<string> CreateProductAsync(Product product);
        public Task<IEnumerable<Product>> GetAllAsync();
        public Task<string> DeleteAsync(string name);
        public Task<string> UpdateAsync(Product Product, string name);
    }
}
