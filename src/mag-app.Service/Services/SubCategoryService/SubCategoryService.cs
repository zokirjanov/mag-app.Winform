
using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces.Categories;
using mag_app.DataAccess.Interfaces.SubCategories;
using mag_app.DataAccess.Repositories.Categories;
using mag_app.DataAccess.Repositories.SubCategories;
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
                return await subCategoryRepository.DeleteAsync(x => x.Id == category.Id);
            }
            return false;
        }

         



        public async Task<List<SubCategory>> GetAllAsync(long cid)
        {
            var result = await subCategoryRepository.GetAllAsync();
            if (result is not null) return result.OrderByDescending(x => x.Id).ToList();
            else return null;
        }



        public async Task<long> GetId(string name)
        {
            var store = await subCategoryRepository.FirstOrDefaultAsync(x => x.SubCategoryName == name);
            return store.Id;
        }




        public async Task<string> UpdateAsync(SubCategoryViewModel category, string name)
        {
            var checkname = await subCategoryRepository.Where(x => x.SubCategoryName == name);
            if (checkname is null)
            {
                var res = await subCategoryRepository.UpdateAsync(category);
                return (res != null) ? "true" : "false";
            }
            else return "Подкатегория уже существует, попробуйте другое название";
        }
    }
}
