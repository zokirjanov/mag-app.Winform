﻿using mag_app.DataAccess.Interfaces.Stores;
using mag_app.DataAccess.Repositories.Stores;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Interfaces.Stores;
using mag_app.Service.ViewModels.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Services.StoreService
{
    public class SaleGlobalService : ISaleGlobalService
    {
        ISaleDetailsRepository _repository;
        public SaleGlobalService()
        {
            _repository = new SaleDetailRepository();
        }
        public async Task<SaleGlobal> CreateAsync(SaleGlobalViewModel viewModel)
        {
            return await _repository.CreateAsync(viewModel);
        }

        public Task<string> DeleteAsync(long Id)
        {
            throw new NotImplementedException();
        }


        public async Task<List<SaleGlobal>> GetAllAsync(long Id)
        {
            var result = await _repository.GetAllAsync(X => X.SaleId == Id);
            if (result is not null) return result.OrderByDescending(x => x.Id).ToList();
            else return null;
        }


        public Task<string> UpdateAsync(SaleGlobal saleDetail, string name)
        {
            throw new NotImplementedException();
        }
    }
}
