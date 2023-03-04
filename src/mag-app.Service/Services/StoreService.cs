using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Accounts;
using mag_app.Service.Dtos.Stores;
using mag_app.Service.Interfaces.Stores;
using mag_app.Service.Security;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Services
{
    public  class StoreService : IStoreService
    {

        private AppDbContext _repository;

   
        public StoreService(AppDbContext repository)
        {
            _repository = repository;

        }

        public async Task<string> CreateAsync(AddStoreDto storeDto)
        {
            var storee = await _repository.Stores.FirstOrDefaultAsync(
            x => x.StoreName.ToLower() == storeDto.StoreName.ToLower() && x.EmployeeId == storeDto.EmployeeID);
            if (storee != null) { return "Store already exists"; }
            var store = (Store)storeDto;
            _repository.Stores.Add(store);
            var res = await _repository.SaveChangesAsync();
            if (res > 0) return "true";
            return "false";
        }

        public async Task<string> DeleteAsync(string name)
        {
            var store = await _repository.Stores.FirstOrDefaultAsync(x=>x.StoreName == name);
            if (store != null)
            {
                var res = _repository.Stores.Remove(store);
                if (res != null)
                {
                    var ss = await _repository.SaveChangesAsync();
                    if(ss > 0) return "true";
                    
                }
                else return "false";
            }
            return "false";
        }

        public async Task<List<Store>> GetAllAsync()
        {
            long id = IdentitySingelton.GetInstance().EmployeeId;
            var result = await _repository.Stores.Where(x => x.EmployeeId == id).ToListAsync();
            if (result is not null)  return result.ToList();
            else return null;
        }

        public async Task<string> UpdateAsync(Store store, string name)
        {
            var entity = await _repository.Stores.FirstOrDefaultAsync(x=>x.StoreName == name);
            if (entity != null)
            {
                entity.StoreName = store.StoreName;
                entity.EmployeeCount= store.EmployeeCount;
                var res = await _repository.SaveChangesAsync();
                if(res > 0) return "true";
                else return "false";
            }
            return "Store not found";
        }
    }
}
