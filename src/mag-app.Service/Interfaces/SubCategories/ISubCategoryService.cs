using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.SubCategories;
using mag_app.Service.Dtos.Categories;
using mag_app.Service.Dtos.SubCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Interfaces.SubCategories
{
    public interface ISubCategoryService
    {
        public Task<string> CreateCategoryAsync(SubCategoryViewModel subCategory);
        public Task<List<SubCategory>> GetAllAsync(long cid);
        public Task<bool> DeleteAsync(long Id);
        public Task<string> UpdateAsync(SubCategoryViewModel category, string name);
    }
}
