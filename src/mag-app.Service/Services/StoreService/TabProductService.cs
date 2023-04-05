﻿using mag_app.DataAccess.Interfaces.Stores;
using mag_app.DataAccess.Repositories.Stores;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Interfaces.Stores;
using mag_app.Service.ViewModels.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var checktabProduct = await tabRepository.FirstOrDefaultAsync(x => x.TabControllerId == tab.TabControllerId);
            if (checktabProduct != null)
            {
                return "Таб уже существует";
            }

            var createTab = (TabProduct)tab;
            var res = await tabRepository.CreateAsync(createTab);

            return (res != null) ? "true" : "Что-то пошло не так";
        }

        public Task<string> DeleteAsync(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TabController>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync(TabProductViewModel tab, string name)
        {
            throw new NotImplementedException();
        }
    }
}
