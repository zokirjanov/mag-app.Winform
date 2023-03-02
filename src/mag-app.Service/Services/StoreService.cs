using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Dtos.Accounts;
using mag_app.Service.Dtos.Stores;
using mag_app.Service.Interfaces.Stores;
using mag_app.Service.Security;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Services
{
    public class StoreService : IStoreService
    {

        private AppDbContext _repository;

   
        public StoreService(AppDbContext repository)
        {
            _repository = repository;
        }

        public async Task<string> CreateAsync(AddStoreDto storeDto)
        {
            var storee = await _repository.Stores.FirstOrDefaultAsync(
            x => x.StoreName.ToLower() == storeDto.StoreName.ToLower());
            if (storee != null) { return "Store already exists"; }
            var store = (Store)storeDto;
            _repository.Stores.Add(store);
            var res = await _repository.SaveChangesAsync();
            if (res > 0) return "true";
            return "false";
        }

        public Task<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Store store, long id)
        {
            throw new NotImplementedException();
        }
    }
}
