﻿using mag_app.DataAccess.DbContexts;
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
            ProdutName = product.ProdutName,
            Barcode = product.Barcode,
            StoreId = product.StoreId,
            StoreName = product.Storename,
            CategoryId = product.CategoryId,
            CategoryName = product.CategoryName,
            SubCategoryId = product.SubCategoryId,
            SubCategoryName = product.SubcategoryName,
            Quantity = product.Quantity,
            PurchasedPrice = product.PurchasedPrice,
            Price = product.Price
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
     //   var result = await allProductRepository.GetAllAsync(x => x.StoreId == cId || x.StoreId == null);
        var result = await allProductRepository.GetAllAsync();
        if (result is not null) return result.OrderByDescending(x => x.Id).ToList();
        else return null;
    }



    public async Task<long> GetId(string name)
    {
        var store = await allProductRepository.FirstOrDefaultAsync(x => x.ProdutName == name);
        return store.Id;
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



    public async Task<string> UpdateAsync(AllProduct product, bool checkname)
    {

        if (checkname)
        {
            var oldproduct = await allProductRepository.FirstOrDefaultAsync(x => x.Barcode == product.Barcode);
            if (oldproduct is not null)
            {
                oldproduct.StoreId = product.StoreId;
                oldproduct.StoreName= product.StoreName;
                oldproduct.ProdutName = product.ProdutName;
                oldproduct.Price = product.Price;
                oldproduct.PurchasedPrice = product.PurchasedPrice;
                oldproduct.Barcode = product.Barcode;
                oldproduct.Quantity += product.Quantity;

                var res = await allProductRepository.UpdateAsync(oldproduct);
                return (res != null) ? "true" : "false";
            }
            else return "товар не найден";
        }

        else
        {
            var checkdb = await allProductRepository.FirstOrDefaultAsync(x => x.ProdutName == product.ProdutName);
            if (checkdb != null) return "Такое название продукта существует, попробуйте другое название товара";

            var oldproduct = await allProductRepository.FirstOrDefaultAsync(x => x.Barcode == product.Barcode);
            if (oldproduct is not null)
            {
                oldproduct.StoreId = product.StoreId;
                oldproduct.StoreName = product.StoreName;
                oldproduct.ProdutName = product.ProdutName;
                oldproduct.Price = product.Price;
                oldproduct.PurchasedPrice = product.PurchasedPrice;
                oldproduct.Quantity += product.Quantity;
                oldproduct.Barcode = product.Barcode;

                var res = await allProductRepository.UpdateAsync(oldproduct);
                return (res != null) ? "true" : "false";
            }
            else return "товар не найден";
        }
    }

}

