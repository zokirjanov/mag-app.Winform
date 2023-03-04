using mag_app.Domain.Entities.Stores;
using mag_app.Service.Dtos.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Interfaces.Stores
{
    public interface IStoreService
    {
        public Task<string> CreateAsync(AddStoreDto storeDto);
        public Task<string> DeleteAsync(string name);
        public Task<string> UpdateAsync(Store store, string name);
        public Task<List<Store>> GetAllAsync();
       
    }
}
