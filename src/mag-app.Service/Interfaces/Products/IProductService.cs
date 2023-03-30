using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Products;
using mag_app.Service.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Interfaces.Products
{
    public interface IproductService
    {
        public Task<(string message, Product product)> CreateProductAsync(ProductViewModel product);
        public Task<IEnumerable<Product>> GetAllAsync(long Id);
        public Task<IEnumerable<Product>> GetAllAsync();
        public Task<bool> DeleteAsync(long Id);
        public Task<string> UpdateAsync(Product Product);
    }
}
