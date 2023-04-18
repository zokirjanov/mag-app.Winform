using mag_app.Domain.Entities.Stores;
using mag_app.Service.ViewModels.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Interfaces.Stores
{
    public interface ISaleGlobalService
    {
        public Task<SaleGlobal> CreateAsync(SaleGlobalViewModel viewModel);
        public Task<string> DeleteAsync(long Id);
        public Task<string> UpdateAsync(SaleGlobal saleDetail, string name);
        public Task<List<SaleGlobal>> GetAllAsync();
    }
}
