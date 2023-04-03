using mag_app.DataAccess.Interfaces.Products;
using mag_app.DataAccess.Repositories.Products;
using mag_app.Domain.Entities.Products;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Interfaces.Products;
using System.Security.Policy;
using System.Xml.Linq;

namespace mag_app.Service.Services.ProductService
{
    public class ProductService : IproductService
    {
        IProductRepository productRepository { get; set; }

        public ProductService()
        {
            productRepository = new ProductRepository();
        }



        public async Task<(string message, Product product)> CreateProductAsync(ProductViewModel productViewModel)
        {
            var check = await productRepository.FirstOrDefaultAsync(x => x.ProdutName == productViewModel.ProdutName && x.SubCategoryId == productViewModel.SubCategoryId);
            if (check is not null) return ("Такое название продукта существует, попробуйте другое название категории", null)!;

            var product = (Product)productViewModel;
            var result = await productRepository.CreateAsync(product);

            if (result != null) return (message: "true", product);
            else return (message: "Что-то пошло не так", null)!;
        }




        public async Task<bool> DeleteAsync(long Id)
        {
            var product = await productRepository.FindByIdAsync(Id);

            if (product != null)
            {
                var res = productRepository.DeleteAsync(x => x.Id == product.Id);

                if (res != null) return true;
                else return false;
            }
            return false;
        }



        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var result = await productRepository.GetAllAsync();
            if (result is not null) return result.OrderByDescending(x => x.Id).ToList();
            else return null;
        }





        public async Task<IEnumerable<Product>> GetAllAsync(long Id)
        {
            var result = await productRepository.GetAllAsync(x => x.SubCategoryId == Id);
            if (result is not null) return result.OrderByDescending(x => x.Id).ToList();
            else return null;
        }





        public async Task<long> GetId(string name)
        {
            var product = await productRepository.FirstOrDefaultAsync(x => x.ProdutName == name);
            return product.Id;
        }





        public async Task<Product> Get(string barcode)
        {
            return await productRepository.GetAsync(x => x.Barcode == barcode);
        }





        public async Task<(string message, Product product)> UpdateAsync(Product product)
        {
            var oldproduct = await productRepository.FirstOrDefaultAsync(x => x.Barcode == product.Barcode);
            if (oldproduct is not null)
            {
                oldproduct.Quantity += product.Quantity;
                var res = await productRepository.UpdateAsync(oldproduct);
                return (res != null) ? (message: "true", oldproduct) : (message: "false", null!);
            }
            else return (message: "товар не найден", null)!;
        }





        public async Task<(string message, Product product)> UpdateAsync(Product product, bool checkname)
        {
            if (checkname)
            {
                var oldproduct = await productRepository.FirstOrDefaultAsync(x => x.Barcode == product.Barcode);
                if (oldproduct is not null)
                {
                    oldproduct.ProdutName = product.ProdutName;
                    oldproduct.Price = product.Price;
                    oldproduct.PurchasedPrice = product.PurchasedPrice;
                    oldproduct.Quantity += product.Quantity;
                    oldproduct.Barcode = product.Barcode;

                    var res = await productRepository.UpdateAsync(oldproduct);
                    return (res != null) ? (message: "true", oldproduct) : (message: "false", null!);
                }
                else return (message: "товар не найден", null)!;
            }

            else
            {
                var checkdb = await productRepository.FirstOrDefaultAsync(x => x.ProdutName == product.ProdutName);
                if (checkdb != null) return (message:"Такое название продукта существует, попробуйте другое название товара",null!);

                var oldproduct = await productRepository.FirstOrDefaultAsync(x => x.Barcode == product.Barcode);
                if (oldproduct is not null)
                {
                    oldproduct.ProdutName = product.ProdutName;
                    oldproduct.Price = product.Price;
                    oldproduct.PurchasedPrice = product.PurchasedPrice;
                    oldproduct.Quantity += product.Quantity;
                    oldproduct.Barcode = product.Barcode;

                    var res = await productRepository.UpdateAsync(oldproduct);
                    return (res != null) ? (message: "true", oldproduct) : (message: "false", null!);
                }
                else return (message: "товар не найден", null)!;
            }
        }
    }
}
