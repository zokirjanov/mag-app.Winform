using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Interfaces.Categories
{
    public interface ICategoryService
    {
        public Task<string> CreateCategoryAsync(Category category);
        public Task<List<Category>> GetAllAsync();
        public Task<bool> DeleteAsync(long id);
        public Task<string> UpdateAsync(Category category, string name);
    }
}
