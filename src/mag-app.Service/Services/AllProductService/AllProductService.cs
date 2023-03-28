using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces;
using mag_app.DataAccess.Repositories.AllProducts;
using mag_app.Domain.Constant;
using mag_app.Domain.Entities.AllProducts;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Stores;
using mag_app.Domain.Entities.SubCategories;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Interfaces.AllProducts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Services.AllProductService
{
    public class AllProductService : IAllProductService
    {
        private AppDbContext _appDbContext;

        public AllProductService(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }




        public async Task<AllProduct> CreateAllProductAsync(AllProduct product)
        {
            AllProduct allProduct = new AllProduct()
            {
                ProductId = product.ProductId,
                StoreId = product.StoreId,
                Quantity = product.Quantity,
                CreatedAt = TimeHelper.CurrentTime(),
                UpdatedAt = TimeHelper.CurrentTime(),
            };

            _appDbContext.AllProducts.Add(allProduct);
            var res = await _appDbContext.SaveChangesAsync();
            return allProduct;
        }



        public Task<string> DeleteAsync(string name)
        {
            throw new NotImplementedException();
        }


        public async Task<IEnumerable<AllProduct>> GetAllAsync(long cId)
        {
            var allProducts = await _appDbContext.AllProducts.Include(x => x.Products).OrderByDescending(x => x.Products.UpdatedAt).ToListAsync();
            return allProducts;
        }

        public async Task<IEnumerable<AllProduct>> GetByNameAsync(long cId, string name)
        {
            var allProducts = await _appDbContext.AllProducts.Include(x => x.Products).Where(x =>x.Products.ProdutName == name).OrderByDescending(x => x.Id).ToListAsync();
            return allProducts;
        }


        public async Task<long> GetById(long pid, long cid)
        {
            var entity = await _appDbContext.AllProducts.FirstOrDefaultAsync(x => x.StoreId == cid && x.ProductId == pid);
            if (entity is not null) return Convert.ToInt64(entity.Id);
            else return -1;
        }


        public async Task<(string message, AllProduct product)> UpdateAsync(AllProduct product)
        {
            var check = await _appDbContext.AllProducts.FirstOrDefaultAsync(x=>x.Id == product.Id);
            if (check != null)
            {
                check.Quantity = product.Quantity;
                var res = await _appDbContext.SaveChangesAsync();
                if (res > 0) { return (message: "true", check); }
                else  return (message: "false", null)!; 
            }
            else return ("Такое  продукта  не  существует", null)!;
        }
    }
}
