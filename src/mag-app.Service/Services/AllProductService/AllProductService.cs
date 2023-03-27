using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Constant;
using mag_app.Domain.Entities.AllProducts;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Interfaces.AllProducts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            IList<AllProduct> list = new List<AllProduct>();

            var products = await _appDbContext.Products.Include(c => c.SubCategory)
                                                       .Include(c => c.SubCategory.Category)
                                                       .ToListAsync();

            var storeProducts = await _appDbContext.AllProducts.Where(x => x.StoreId == cId)
                                                               .Include(x => x.Products)
                                                               .ToListAsync();

            foreach (var item in products)
            {
                AllProduct product = new AllProduct();

                foreach (var item1 in storeProducts)
                {
                    if (item.Id == item1.ProductId)
                    {
                        product = item1;
                    }
                }

                if (product.Id != 0)
                {
                    list.Add(product);
                }
                else
                {
                    product.Products = item;
                    list.Add(product);
                }
            }

            return list;
        }

        public async Task<string> UpdateAsync(AllProduct Product, string name)
        {
            throw new NotImplementedException();
        }
    }
}
