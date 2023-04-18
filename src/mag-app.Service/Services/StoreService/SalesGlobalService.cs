using mag_app.DataAccess.Interfaces.Stores;
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

namespace mag_app.Service.Services.StoreService
{
    public class SalesGlobalService : ISalesGlobalService
    {
        ISalesGlobalRepository _repository;

        public SalesGlobalService()
        {
            _repository = new SalesGlobalRepository();
        }
        
        public async Task<SaleDetail> CreateAsync(SaleDetailsViewModel viewModel)
        {
            return await _repository.CreateAsync(viewModel);
        }

        public Task<string> DeleteAsync(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SaleDetail>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync(SaleDetail salesGlobal, string name)
        {
            throw new NotImplementedException();
        }
    }
}
