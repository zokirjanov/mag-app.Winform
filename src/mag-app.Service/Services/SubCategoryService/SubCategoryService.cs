
using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces.SubCategories;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.SubCategories;
using mag_app.Service.Common.Helpers;
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
        public SubCategoryService subCategoryService;
        private AppDbContext _appDbContext;
        public SubCategoryService(AppDbContext appDbContext)
        {
            subCategoryService = this;
            _appDbContext = appDbContext;
        }



        public async Task<string> CreateCategoryAsync(SubCategoryDto subCategory)
        {
            var check = await _appDbContext.SubCategories.FirstOrDefaultAsync(x => x.SubCategoryName == subCategory.SubCategoryName && x.CategoryId == subCategory.CategoryId);
            if (check is not null) return "Такая подкатегория существует, попробуйте другое название подкатегории";
            var cat = (SubCategory)subCategory;
            _appDbContext.SubCategories.Add(cat);
            var res = await _appDbContext.SaveChangesAsync();
            if (res > 0) return "true";
            return "Что-то пошло не так";
        }




        public async Task<bool> DeleteAsync(string subcategoryName)
        {
            var check = await _appDbContext.SubCategories.FirstOrDefaultAsync(x => x.SubCategoryName == subcategoryName);
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




        public async Task<List<SubCategory>> GetAllAsync(long cid)
        {
            var result = await _appDbContext.SubCategories.Where(x => x.CategoryId == cid).OrderByDescending(x => x.CreatedAt).ToListAsync();
            if (result is not null) return result.ToList();
            else return null;
        }




        public async Task<long> GetByNameAsync(string name)
        {
            var result = await _appDbContext.SubCategories.FirstOrDefaultAsync(x => x.SubCategoryName == name);
            if (result is not null)
            {
                return result.Id;
            }
            else return 0;
        }




        public async Task<string> UpdateAsync(SubCategoryDto category, string name)
        {
            var checkname = await _appDbContext.SubCategories.FirstOrDefaultAsync(x => x.SubCategoryName == category.SubCategoryName.ToLower());
            if (checkname is null)
            {
                var entity = await _appDbContext.SubCategories.FirstOrDefaultAsync(x => x.SubCategoryName == name);
                if (entity != null)
                {
                    entity.SubCategoryName = category.SubCategoryName;
                    var res = await _appDbContext.SaveChangesAsync();
                    if (res > 0) { return "true"; }
                    else { return "false"; }
                }
                return "false";
            }
            else return "Подкатегория уже существует, попробуйте другое название";
        }
    }
}
