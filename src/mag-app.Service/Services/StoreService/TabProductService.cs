﻿using mag_app.DataAccess.Interfaces.Stores;
using mag_app.DataAccess.Repositories.AllProducts;
using mag_app.DataAccess.Repositories.Stores;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Interfaces.Stores;
using mag_app.Service.ViewModels.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using mag_app.DataAccess.DbContexts;

namespace mag_app.Service.Services.StoreService
{
    public class TabProductService : ITabProductService
    {
        ITabProductRepository tabRepository;


        public TabProductService()
        {
            tabRepository= new TabProductRepository();
        }



        public async Task<string> CreateAsync(TabProductViewModel tab)
        {
            var checktabProduct = await tabRepository.FirstOrDefaultAsync(x => x.TabControllerId == tab.TabControllerId && x.AllProduct.Id == tab.ProductId);
            if (checktabProduct != null)
            {
                return "exists";
            }

            var createTab = (TabProduct)tab;
            var res = await tabRepository.CreateAsync(createTab);

            return (res != null) ? "true" : "false";
        }




        public Task<string> DeleteAsync(long Id)
        {
            throw new NotImplementedException();
        }


        public async Task<List<TabProduct>> GetAll_WithTabAsync(long Tid)
        {
            var result = await tabRepository.GetAllAsync(x=>x.TabControllerId == Tid);
            if (result is not null) return result.OrderByDescending(x => x.Id).ToList();
            else return null;
        }


        public async Task<List<TabProduct>> GetAllAsync(long tId)
        {
            var db = new AppDbContext();

            var result = await db.Tabproducts.Where(x => x.TabControllerId == tId).Include(x => x.AllProduct).ToListAsync();
            if (result is not null) return result.OrderByDescending(x => x.Id).ToList();
            else return null;
        }




        public async Task<TabProduct> GetAsync(string barcode)
        {
            return await tabRepository.FirstOrDefaultAsync(x => x.AllProduct.Barcode == barcode);
        }
    }
}
