using mag_app.Domain.Entities.Stores;
using mag_app.Service.ViewModels.Stores;

namespace mag_app.Service.Interfaces.Stores
{
    public interface ISalesGlobalService
    {
        public Task<SaleDetail> CreateAsync(SaleDetailsViewModel viewModel);
        public Task<string> DeleteAsync(long Id);
        public Task<string> UpdateAsync(SaleDetail salesGlobal, string name);
        public Task<List<SaleDetail>> GetAllAsync();
    }
}
