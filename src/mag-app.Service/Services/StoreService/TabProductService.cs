using mag_app.DataAccess.Interfaces.Stores;
using mag_app.DataAccess.Repositories.Stores;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Interfaces.Stores;
using mag_app.Service.ViewModels.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Services.StoreService
{
    public class TabProductService : ITabProductService
    {
        ITabProductRepository tabRepository;


        public TabProductService()
        {
            tabRepository= new TabProductRepository();
        }



        public async Task<string> CreateAsync(TabProductViewModel tab)
        {
            var checktabProduct = await tabRepository.FirstOrDefaultAsync(x => x.TabControllerId == tab.TabControllerId && x.Product.Id == tab.ProductId);
            if (checktabProduct != null)
            {
                return "exists";
            }

            var createTab = (TabProduct)tab;
            var res = await tabRepository.CreateAsync(createTab);

            return (res != null) ? "true" : "false";
        }

        public Task<string> DeleteAsync(long Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TabProduct>> GetAllAsync(long tId)
        {
            var result = await tabRepository.GetAllAsync(x=>x.TabControllerId == tId);
            if (result is not null) return result.OrderByDescending(x => x.Id).ToList();
            else return null;
        }

        public Task<string> UpdateAsync(TabProductViewModel tab, string name)
        {
            throw new NotImplementedException();
        }
    }
}
