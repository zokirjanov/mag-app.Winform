using mag_app.Domain.Entities.Stores;
using mag_app.Service.ViewModels.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Interfaces.Stores
{
    public interface ITabProductService
    { 
        public Task<string> CreateAsync(TabProductViewModel tab);
        public Task<string> DeleteAsync(long Id);
        public Task<TabProduct> GetAsync(string barcode);
        public Task<bool> UpdateAsync(long id, decimal qnt);
        public Task<List<TabProduct>> GetAllAsync(long tID);
    }
}
