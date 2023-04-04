using mag_app.Domain.Entities.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Interfaces.Stores
{
    public interface ITabService
    {
        public Task<string> CreateAsync(TabController tab);
        public Task<string> DeleteAsync(long Id);
        public Task<string> UpdateAsync(TabController tab, string name);
        public Task<List<TabController>> GetAllAsync();
    }
}
