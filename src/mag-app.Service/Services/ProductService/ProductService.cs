using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
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
        public async Task<string> CreateProductAsync(ProductDto product)
        {
            var check = await _appDbContext.Products.FirstOrDefaultAsync(x => x.ProdutName == product.ProdutName);
            if (check is not null) return "Such a Product name exists, try another category name";
            var pro = (Product)product;
            _appDbContext.Products.Add(pro);
            var res = await _appDbContext.SaveChangesAsync();
            if (res > 0) return "true";
            return "Something went wrong";
        }

        public async Task<string> DeleteAsync(string name)
        {
            var product = await _appDbContext.Products.FirstOrDefaultAsync(x => x.ProdutName == name);
            if (product != null)
            {
                var res = _appDbContext.Products.Remove(product);
                if (res != null)
                {
                    var ss = await _appDbContext.SaveChangesAsync();
                    if (ss > 0) return "Successfully deleted";
                }
                else return "Something went wrong";
            }
            return "Product not found";
        }

        public async Task<IEnumerable<Product>> GetAllAsync(long cid, long eid)
        {
            var result = await _appDbContext.Products.Where(x => x.SubCategoryId == cid && x.EmployeeId == eid).ToListAsync();
            if (result is not null) return result.ToList();
            else return null;
        }

        public async Task<IEnumerable<Product>> GetByNameAsync(string name, long eid)
        {
            var result = await _appDbContext.Products.Where(x => x.ProdutName == name && x.EmployeeId == eid).ToListAsync();
            if (result is not null) return result.ToList();
            else return null;
        }

        public async Task<int> GetTotal()
        {
            var count =  _appDbContext.Products.Count();
            return count;
        }

        public async Task<string> UpdateAsync(ProductDto product, string name)
        {
            var checkname = await _appDbContext.Products.FirstOrDefaultAsync(x => x.ProdutName.ToLower() == product.ProdutName.ToLower());
            if (checkname is null)
            {
                var entity = await _appDbContext.Products.FirstOrDefaultAsync(x => x.ProdutName == name);
                if (entity != null)
                {
                    entity.ProdutName = product.ProdutName;
                    var res = await _appDbContext.SaveChangesAsync();
                    if (res > 0) { return "true"; }
                    else { return "false"; }
                }
                return "false";
            }
            else return "Producty already exists, please try another name";
        }
    }
}
