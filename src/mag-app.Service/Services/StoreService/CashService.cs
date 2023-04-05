using mag_app.DataAccess.Interfaces.Stores;
using mag_app.DataAccess.Repositories.Stores;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Dtos.Stores;
using mag_app.Service.Interfaces.Stores;
using mag_app.Service.ViewModels.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Services.StoreService
{
    public class CashService : ICashService
    {
        private ICashRepository cashRepository;

        public CashService()
        {
            cashRepository = new CashRepository();
        }


        public async Task<string> CreateAsync(CashViewModel cashViewModel)
        {
            var storee = await cashRepository.FirstOrDefaultAsync(x => x.CashName == cashViewModel.StoreName);
            if (storee != null)
            {
                return "Касса уже существует";
            }

            var store = (Cash)cashViewModel;
            var res = await cashRepository.CreateAsync(store);

            return (res != null) ? "true" : "Что-то пошло не так";
        }



        public async Task<string> DeleteAsync(long Id)
        {
            var cash = await cashRepository.FindByIdAsync(Id);

            if (cash != null)
            {
                var res = cashRepository.DeleteAsync(x => x.Id == cash.Id);
                if (res != null) return "true";
                else return "false";
            }
            return "false";
        }



        public async Task<List<Cash>> GetAllAsync(long id)
        {
            var result = await cashRepository.GetAllAsync(x=>x.StoreId == id);
            if (result is not null) return result.OrderByDescending(x => x.Id).ToList();
            else return null;
        }


        public async Task<long> GetId(string name)
        {
            var store = await cashRepository.FirstOrDefaultAsync(x => x.CashName == name);
            return store.Id;
        }


        public async Task<string> UpdateAsync(Cash cash, string name)
        {
            var checkname = await cashRepository.FirstOrDefaultAsync(x => x.CashName == cash.CashName);

            if (checkname is null)
            {
                var oldStore = await cashRepository.FirstOrDefaultAsync(x => x.CashName == name);
                oldStore.CashName = cash.CashName;
                var res = await cashRepository.UpdateAsync(oldStore);
                return (res != null) ? "true" : "false";
            }
            else return "касса уже существует, попробуйте другое название";
        }
    }
}
