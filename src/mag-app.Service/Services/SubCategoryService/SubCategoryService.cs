
using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces.SubCategories;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.SubCategories;
using mag_app.Service.Dtos.Categories;
using mag_app.Service.Dtos.SubCategories;
using mag_app.Service.Interfaces.SubCategories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Services.SubCategoryService
{
    public class SubCategoryService : ISubCategoryService
    {
        private AppDbContext _appDbContext;
        public SubCategoryService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<string> CreateCategoryAsync(SubCategoryDto subCategory)
        {
            var check = await _appDbContext.SubCategories.FirstOrDefaultAsync(x => x.SubCategoryName == subCategory.SubCategoryName && x.CategoryId == subCategory.CategoryId);
            if (check is not null) return "Such a sub-category exists, try another sub-category name";
            var cat = (SubCategory)subCategory;
            _appDbContext.SubCategories.Add(cat);
            var res = await _appDbContext.SaveChangesAsync();
            if (res > 0) return "true";
            return "Something went wrong";
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var check = await _appDbContext.SubCategories.FirstOrDefaultAsync(x => x.Id == id);
            if (check != null)
            {
                var res = _appDbContext.SubCategories.Remove(check);
                if (res != null)
                {
                    var ss = await _appDbContext.SaveChangesAsync();
                    if (ss > 0) return true;
                }
                else return false;
            }
            return false;
        }

        public Task<List<Category>> GetAllAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<long> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync(CategoryDto category, string name)
        {
            throw new NotImplementedException();
        }
    }
}
