using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Stores;
using mag_app.Service.Interfaces.Stores;
using Microsoft.EntityFrameworkCore;

namespace mag_app.Service.Services.StoreService
{
    public class StoreService : IStoreService
    {

        private AppDbContext _appDbContext;

        public StoreService(AppDbContext repository)
        {
            _appDbContext = repository;
        }

        public async Task<string> CreateAsync(AddStoreDto storeDto)
        {
            var storee = await _appDbContext.Stores.FirstOrDefaultAsync(
            x => x.StoreName.ToLower() == storeDto.StoreName.ToLower() && x.UserId == storeDto.UserId);
            if (storee != null) { return "Категория уже существует"; }
            var store = (Store)storeDto;
            _appDbContext.Stores.Add(store);
            var res = await _appDbContext.SaveChangesAsync();
            if (res > 0) return "true";
            return "Что-то пошло не так";
        }

        public async Task<string> DeleteAsync(string name)
        {
            var store = await _appDbContext.Stores.FirstOrDefaultAsync(x => x.StoreName == name);
            if (store != null)
            {
                var res = _appDbContext.Stores.Remove(store);
                if (res != null)
                {
                    var ss = await _appDbContext.SaveChangesAsync();
                    if (ss > 0) return "true";
                }
                else return "false";
            }
            return "false";
        }

        public async Task<List<Store>> GetAllAsync()
        {
            long id = IdentitySingelton.GetInstance().UserId;
            var result = await _appDbContext.Stores.Where(x => x.UserId == id).ToListAsync();
            if (result is not null) return result.ToList();
            else return null;
        }

        public async Task<long> GetByName(string name)
        {
            var result = _appDbContext.Stores.First(x => x.StoreName == name);
            if (result is not null)
            {
                return  result.Id;
            }        
            else return 0;
        }

        public async Task<string> UpdateAsync(Store store, string name)
        {
            var checkname = await _appDbContext.Stores.FirstOrDefaultAsync(x => x.StoreName.ToLower() == store.StoreName.ToLower());
            if (checkname is null)
            {
                var entity = await _appDbContext.Stores.FirstOrDefaultAsync(x => x.StoreName == name);
                if (entity != null)
                {
                    entity.StoreName = store.StoreName;
                    var res = await _appDbContext.SaveChangesAsync();
                    if (res > 0) { return "true"; }
                    else { return "false"; }
                }
                return "false";
            }
            else return "Категория уже существует, попробуйте другое название";
        }
    }
}
