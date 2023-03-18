using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.SubCategories;
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
        public Task<List<SubCategory>> GetAllAsync(long cid, long eid, long sid);
        public Task<bool> DeleteAsync(string subcategoryName);
        public Task<string> UpdateAsync(SubCategoryDto category, string name);
        public Task<long> GetByNameAsync(string name);
    }
}
