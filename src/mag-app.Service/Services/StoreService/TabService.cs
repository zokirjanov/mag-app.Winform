using mag_app.DataAccess.Interfaces.Stores;
using mag_app.DataAccess.Repositories.AllProducts;
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
    public class TabService : ITabService
    {

        ITabRepository tabRepository;

        public TabService()
        {
            tabRepository= new TabRepository();
        }


        public async Task<string> CreateAsync(TabController tab)
        {
            var checktab = await tabRepository.FirstOrDefaultAsync(x => x.TabName == tab.TabName);
            if (checktab != null)
            {
                return "Таб уже существует";
            }

            var createTab = (TabController)tab;
            var res = await tabRepository.CreateAsync(createTab);

            return (res != null) ? "true" : "Что-то пошло не так";
        }


        public Task<string> DeleteAsync(long Id)
        {
            throw new NotImplementedException();
        }


        public async Task<List<TabController>> GetAllAsync()
        {
            var result = await tabRepository.GetAllAsync();
            if (result is not null) return result.OrderByDescending(x => x.Id).ToList();
            else return null;
        }


        public async Task<long> GetId(string name)
        {
            var tab = await tabRepository.FirstOrDefaultAsync(x => x.TabName == name);
            return (tab == null) ? -1 : tab.Id;
        }


        public Task<string> UpdateAsync(TabController tab, string name)
        {
            throw new NotImplementedException();
        }
    }
}
