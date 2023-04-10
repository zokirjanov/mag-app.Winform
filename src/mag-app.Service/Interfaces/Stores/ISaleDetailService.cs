using mag_app.Domain.Entities.Stores;
using mag_app.Service.ViewModels.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Interfaces.Stores
{
    public interface ISaleDetailService
    {
        public Task<string> CreateAsync(SaleDetailsViewModel viewModel);
        public Task<string> DeleteAsync(long Id);
        public Task<string> UpdateAsync(SaleDetail saleDetail, string name);
        public Task<List<SaleDetail>> GetAllAsync();
    }
}
