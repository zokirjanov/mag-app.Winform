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
        public Task<string> CreateAsync(SalesGlobalViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteAsync(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SalesGlobal>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync(SalesGlobal salesGlobal, string name)
        {
            throw new NotImplementedException();
        }
    }
}
