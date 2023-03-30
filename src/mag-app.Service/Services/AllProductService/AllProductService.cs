using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces.AllProducts;
using mag_app.DataAccess.Interfaces.Products;
using mag_app.DataAccess.Repositories.AllProducts;
using mag_app.DataAccess.Repositories.Products;
using mag_app.Domain.Entities.AllProducts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Interfaces.AllProducts;
using Microsoft.EntityFrameworkCore;

namespace mag_app.Service.Services.AllProductService;

public class AllProductService : IAllProductService
{
    IAllProductRepository allProductRepository { get; set; }

    public AllProductService()
    {
        allProductRepository = new AllProductRepository();
    }




    public async Task<AllProduct> CreateAllProductAsync(AllProductViewModel product)
    {
        AllProduct allProduct = new AllProduct()
        {
            StoreId = product.StoreId,
            StoreName = product.Storename,
            CategoryId = product.CategoryId,
            CategoryName = product.CategoryName,
            SubCategoryId = product.SubCategoryId,
            SubCategoryName = product.SubcategoryName,
            Quantity = product.Quantity,
        };

        return await allProductRepository.CreateAsync(allProduct);
    }



    public async Task<bool> DeleteAsync(long Id)
    {
        var checkProduct = await allProductRepository.FirstOrDefaultAsync(x => x.Id == Id);

        if (checkProduct != null)
        {
            var res = await allProductRepository.DeleteAsync(x => x.Id == checkProduct.Id);
            return (res) ? true : false;
        }
        return false;
    }




    public async Task<IEnumerable<AllProduct>> GetAllAsync(long cId)
    {
        var result = await allProductRepository.GetAllAsync();
        if (result is not null) return result.OrderByDescending(x => x.Id).ToList();
        else return null;
    }





    public async Task<string> UpdateAsync(AllProduct product)
    {

        var oldproduct = await allProductRepository.FirstOrDefaultAsync(x => x.ProdutName == product.ProdutName);

        if (oldproduct != null) return ("Такое название продукта существует, попробуйте другое название товара");

        else
        {
            oldproduct.ProdutName = product.ProdutName;
            oldproduct.Price = product.Price;
            oldproduct.PurchasedPrice = product.PurchasedPrice;
            oldproduct.Quantity = product.Quantity;
            oldproduct.Barcode = product.Barcode;

            var res = await allProductRepository.UpdateAsync(oldproduct);

            return (res != null)? "true":"false";
        }
    }

}

