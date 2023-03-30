using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Products;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Interfaces.Products;
using Microsoft.EntityFrameworkCore;

namespace mag_app.Service.Services.ProductService
{
    public class ProductService : IproductService
    {
        private AppDbContext _appDbContext;

        public ProductService(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }



        public async Task<(string message, Product product)> CreateProductAsync(ProductViewModel product)
        {
            var check = await _appDbContext.Products.FirstOrDefaultAsync(x => x.ProdutName == product.ProdutName && x.SubCategoryId == product.SubCategoryId);
            if (check is not null) return ("Такое название продукта существует, попробуйте другое название категории", null)!;
            var pro = (Product)product;
            _appDbContext.Products.Add(pro);
            var res = await _appDbContext.SaveChangesAsync();
            if (res > 0) return ("true", pro)!;
            return ("Что-то пошло не так", null)!;
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
                    if (ss > 0) return "Успешно удалено";
                }
                else return "Что-то пошло не так";
            }
            return "Товар не найден";
        }




        public async Task<IEnumerable<Product>> GetAllAsync(long cId)
        {
            var result = await _appDbContext.Products.Where(x => x.SubCategoryId == cId).OrderByDescending(x => x.CreatedAt).ToListAsync();
            if (result is not null) return result.ToList();
            else return null;
        }


        public async Task<long> GetByNameAsync(string name)
        {
            var result = await _appDbContext.Products.FirstOrDefaultAsync(x=> x.ProdutName == name);
            if (result is not null) return Convert.ToInt64(result.Id);
            else return 0;
        }



        public async Task<string> UpdateAsync(ProductViewModel product, string name)
        {
         // var checkname = await _appDbContext.Products.FirstOrDefaultAsync(x => x.ProdutName.ToLower() == product.ProdutName.ToLower());
            var entity = await _appDbContext.Products.FirstOrDefaultAsync(x => x.ProdutName == name);
            if (entity != null)
            {
                entity.ProdutName = product.ProdutName;
                entity.PurchasedPrice = product.PurchasedPrice;
                entity.Price = product.Price;
                entity.Barcode= product.Barcode;
                entity.UpdatedAt = product.UpdatedAt;

                var res = await _appDbContext.SaveChangesAsync();
                if (res > 0) { return "true"; }
                else { return "false"; }
            }
            return "false";
        }
    }
}
