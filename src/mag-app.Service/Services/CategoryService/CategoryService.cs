using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces.Categories;
using mag_app.DataAccess.Interfaces.Stores;
using mag_app.DataAccess.Repositories.Categories;
using mag_app.DataAccess.Repositories.Stores;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Categories;
using mag_app.Service.Dtos.Stores;
using mag_app.Service.Interfaces.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mag_app.Service.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository categoryRepository { get; set; }
    
        public CategoryService()
        {
            categoryRepository = new CategoryRepository();
        }



        public async Task<string> CreateCategoryAsync(CategoryViewModel categoryViewModel)
        {
            var categoryCheck = await categoryRepository.FirstOrDefaultAsync(x => x.CategoryName == categoryViewModel.CategoryName);
            if (categoryCheck != null)
            {
                return "Категория уже существует";
            }

            var category = (Category)categoryViewModel;
            var res = await categoryRepository.CreateAsync(category);

            return (res != null)?  "true": "Что-то пошло не так";
        }




        public async Task<bool> DeleteAsync(long Id)
        {
            var category = await categoryRepository.FindByIdAsync(Id);

            if (category != null)
            {
                return await categoryRepository.DeleteAsync(x => x.Id == category.Id);
            }
            return false;
        }




        public async Task<List<Category>> GetAllAsync()
        {
            var result = await categoryRepository.GetAllAsync();
            if (result is not null) return result.OrderByDescending(x => x.Id).ToList();
            else return null;
        }





        public async Task<string> UpdateAsync(CategoryViewModel category, string name)
        {
            var checkname = await categoryRepository.Where(x => x.CategoryName == name);
            if (checkname is null)
            {
                var res = await categoryRepository.UpdateAsync(category);
                return (res != null) ? "true" : "false";
            }
            else return "Категория уже существует, попробуйте другое название";
        }
    }
}
