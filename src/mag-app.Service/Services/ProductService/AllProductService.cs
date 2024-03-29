﻿using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces.AllProducts;
using mag_app.DataAccess.Interfaces.Products;
using mag_app.DataAccess.Repositories.AllProducts;
using mag_app.DataAccess.Repositories.Products;
using mag_app.Domain.Entities.Products;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Interfaces.Products;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace mag_app.Service.Services.ProductService;

public class AllProductService : IAllProductService
{
    IAllProductRepository allProductRepository { get; set; }
    private AppDbContext appDb;

    public AllProductService()
    {
        allProductRepository = new AllProductRepository();
        appDb = new AppDbContext();
    }




    public async Task<AllProduct> CreateAllProductAsync(AllProductViewModel product)
    {
        AllProduct allProduct = new AllProduct()
        {
            ProdutName = product.ProdutName,
            ProductId = product.ProductId,
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
            return res ? true : false;
        }
        return false;
    }




    public async Task<IEnumerable<AllProduct>> GetAllAsync(long cId)
    {
        IList<AllProduct> resultList = new List<AllProduct>();
        var products = await appDb.Products.OrderByDescending(x => x.Id).ToListAsync();
        var allProducts = await appDb.AllProducts.Where(x => x.StoreId == cId).Include(x => x.Product).ToListAsync();

        foreach (var prod in products)
        {
            AllProduct allProduct = new AllProduct();

            foreach (var allProd in allProducts)
            {
                if (prod.Id == allProd.ProductId)
                {
                    allProduct = allProd;
                }
            }

            if (allProduct.Id != 0)
            {
                resultList.Add(allProduct);
            }
            else
            {
                allProduct.Product = prod;
                allProduct.Barcode = prod.Barcode;
                allProduct.ProdutName = prod.ProdutName;
                allProduct.CategoryId = prod.CategoryId;
                allProduct.CategoryName = prod.CategoryName;
                allProduct.SubCategoryId = prod.SubCategoryId;
                allProduct.SubCategoryName = prod.SubCategoryName;
                allProduct.PurchasedPrice = prod.PurchasedPrice;
                allProduct.Price = prod.Price;
                allProduct.Quantity = 0;
                resultList.Add(allProduct);
            }
        }
        return resultList;
    }


    public async Task<AllProduct> GetAsync(string barcode, long sId)
    {
        return await allProductRepository.GetAsync(x => x.Barcode == barcode && x.StoreId == sId);
    }


    public async Task<long> GetId(string name)
    {
        var product = await allProductRepository.FirstOrDefaultAsync(x => x.ProdutName == name);
        return product == null ? -1 : product.Id;
    }


    public async Task<bool> UpdateAsync(long id, decimal qnt)
    {
        var oldproduct = await allProductRepository.FirstOrDefaultAsync(x => x.Id == id);

        if (oldproduct == null)
        {
            return false;
        }
        else
        {
            oldproduct.Quantity -= qnt;

            var res = await allProductRepository.UpdateAsync(oldproduct);

            return res != null ? true : false;
        }
    }



    public async Task<string> UpdateAsync(AllProduct product)
    {

        var oldproduct = await allProductRepository.FirstOrDefaultAsync(x => x.ProdutName == product.ProdutName);

        if (oldproduct != null) return "Такое название продукта существует, попробуйте другое название товара";

        else
        {
            oldproduct.ProdutName = product.ProdutName;
            oldproduct.Price = product.Price;
            oldproduct.PurchasedPrice = product.PurchasedPrice;
            oldproduct.Quantity = product.Quantity;
            oldproduct.Barcode = product.Barcode;

            var res = await allProductRepository.UpdateAsync(oldproduct);

            return res != null ? "true" : "false";
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
                oldproduct.StoreName = product.StoreName;
                oldproduct.ProdutName = product.ProdutName;
                oldproduct.Price = product.Price;
                oldproduct.PurchasedPrice = product.PurchasedPrice;
                oldproduct.Barcode = product.Barcode;
                oldproduct.Quantity += product.Quantity;

                var res = await allProductRepository.UpdateAsync(oldproduct);
                return res != null ? "true" : "false";
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
                return res != null ? "true" : "false";
            }
            else return "товар не найден";
        }
    }

}

