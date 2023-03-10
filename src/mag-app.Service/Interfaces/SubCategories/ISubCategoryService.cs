using mag_app.Domain.Entities.Categories;
using mag_app.Service.Dtos.Categories;
using mag_app.Service.Dtos.SubCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Interfaces.SubCategories
{
    public interface ISubCategoryService
    {
        public Task<string> CreateCategoryAsync(SubCategoryDto subCategory);
        public Task<List<Category>> GetAllAsync(long id);
        public Task<bool> DeleteAsync(long id);
        public Task<string> UpdateAsync(CategoryDto category, string name);
        public Task<long> GetByName(string name);
    }
}
