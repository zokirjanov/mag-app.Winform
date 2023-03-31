
using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces.Categories;
using mag_app.DataAccess.Interfaces.SubCategories;
using mag_app.DataAccess.Repositories.Categories;
using mag_app.DataAccess.Repositories.Products;
using mag_app.DataAccess.Repositories.SubCategories;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Products;
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
        private ISubCategoryRepository subCategoryRepository { get; set; }


        public SubCategoryService()
        {
            subCategoryRepository = new SubCategoryRepository();
        }




        public async Task<string> CreateCategoryAsync(SubCategoryViewModel subCategoryViewModel)
        {
            var subCategoryCheck = await subCategoryRepository.FirstOrDefaultAsync(x => x.SubCategoryName == subCategoryViewModel.SubCategoryName);
            if (subCategoryCheck != null)
            {
                return "Такая подкатегория существует, попробуйте другое название подкатегории";
            }

            var subCategory = (SubCategory)subCategoryViewModel;
            var res = await subCategoryRepository.CreateAsync(subCategory);

            return (res != null) ? "true" : "Что-то пошло не так";
        }





        public async Task<bool> DeleteAsync(long Id)
        {
            var category = await subCategoryRepository.FindByIdAsync(Id);

            if (category != null)
            {
                return await subCategoryRepository.DeleteAsync(x => x.Id == Id);
            }
            return false;
        }

         



        public async Task<List<SubCategory>> GetAllAsync(long cid)
        {
            var result = await subCategoryRepository.GetAllAsync(x=>x.CategoryId == cid);
            if (result is not null) return result.OrderByDescending(x => x.Id).ToList();
            else return null;
        }





        public async Task<long> GetId(string name)
        {
            var store = await subCategoryRepository.FirstOrDefaultAsync(x => x.SubCategoryName == name);
            return store.Id;
        }




        public async Task<string> UpdateAsync(SubCategoryViewModel category, string oldname)
        {
            var checkname = await subCategoryRepository.FirstOrDefaultAsync(x => x.SubCategoryName == category.SubCategoryName);

            if (checkname is null)
            {
                var oldSubCategory = await subCategoryRepository.FirstOrDefaultAsync(x => x.SubCategoryName == oldname);
                oldSubCategory.SubCategoryName = category.SubCategoryName;
                var res = await subCategoryRepository.UpdateAsync(oldSubCategory);
                return (res != null) ? "true" : "false";
            }
            else return "категория уже существует, попробуйте другое название";
        }
    }
}
