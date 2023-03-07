using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Products;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Interfaces.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Services.ProductService
{
    public class ProductService : IproductService
    {
        private AppDbContext _appDbContext;

        public ProductService(AppDbContext appDbContext)
        {
              this._appDbContext = appDbContext;
        }
        public async Task<string> CreateProductAsync(Product product)
        {
            var check = await _appDbContext.Products.FirstOrDefaultAsync(x => x.ProdutName == product.ProdutName);
            if (check is not null) return "Such a Product name exists, try another category name";
            var pro = (Product)product;
            _appDbContext.Products.Add(pro);
            var res = await _appDbContext.SaveChangesAsync();
            if (res > 0) return "true";
            return "Something went wrong";
        }

        public Task<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            long id = IdentitySingelton.GetInstance().EmployeeId;
            var result = await _appDbContext.Products.ToListAsync();
            if (result is not null) return result.ToList();
            else return null;
        }

        public Task<bool> UpdateAsync(long id, Product Product)
        {
            throw new NotImplementedException();
        }
    }
}
