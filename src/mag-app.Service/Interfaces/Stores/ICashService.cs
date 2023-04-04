using mag_app.Domain.Entities.Stores;
using mag_app.Service.Dtos.Stores;
using mag_app.Service.ViewModels.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Interfaces.Stores
{
    public interface ICashService
    {
        public Task<string> CreateAsync(CashViewModel cashViewModel);
        public Task<string> DeleteAsync(long Id);
        public Task<string> UpdateAsync(Cash cash, string name);
        public Task<List<Cash>> GetAllAsync();
    }
}
