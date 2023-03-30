using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces.Stores;
using mag_app.DataAccess.Repositories.Stores;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Stores;
using mag_app.Service.Interfaces.Stores;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace mag_app.Service.Services.StoreService
{
    public class StoreService : IStoreService
    {
        private IStoreRepository storeRepository { get; set; }
        public StoreService()
        {
            storeRepository = new StoreRepository();
        }



        public async Task<string> CreateAsync(StoreViewModel storeViewModel)
        {
            var storee = await storeRepository.FirstOrDefaultAsync(x=>x.StoreName == storeViewModel.StoreName);
            if (storee != null) 
            {
                return "Магазин уже существует";
            }
           
            var store = (Store)storeViewModel;
            var res = await storeRepository.CreateAsync(store);

            return (res != null) ? "true" : "Что-то пошло не так";
        }




        public async Task<string> DeleteAsync(long Id)
        {
            var store = await storeRepository.FindByIdAsync(Id);

            if (store != null)
            {
                var res = storeRepository.DeleteAsync(x => x.Id == store.Id);
                if (res != null)  return "true";
                else return "false";
            }
            return "false";
        }



        public async Task<List<Store>> GetAllAsync()
        {
            var result = await storeRepository.GetAllAsync();
            if (result is not null) return result.OrderByDescending(x=>x.Id).ToList();
            else return null;
        }



        public async Task<long> GetId(string name)
        {
            var store = await storeRepository.FirstOrDefaultAsync(x => x.StoreName == name);
            return store.Id;
        }



        public async Task<string> UpdateAsync(Store store, string name)
        {
            var checkname = await storeRepository.FirstOrDefaultAsync(x => x.StoreName == name);
            if (checkname is null)
            {
                var res = await storeRepository.UpdateAsync(store);
                return (res != null)?  "true" : "false";
            }
            else return "магазин уже существует, попробуйте другое название";
        }
    }
}
