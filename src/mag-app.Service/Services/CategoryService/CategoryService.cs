﻿using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Categories;
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
        private AppDbContext _appDbContext;
        public CategoryService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<string> CreateCategoryAsync(CategoryDto category)
        {
            var check = await _appDbContext.Categories.FirstOrDefaultAsync(x => x.CategoryName == category.CategoryName && x.StoreId == category.StoreId && x.EmployeeId == category.EmployeeId);
            if (check is not null) return "Such a category exists, try another category name";
            var cat = (Category)category;
            _appDbContext.Categories.Add(cat);
            var res = await _appDbContext.SaveChangesAsync();
            if (res > 0) return "true";
            return "Something went wrong";
        }

        public async Task<bool> DeleteAsync(string  categoryName)
        {
            var check = await _appDbContext.Categories.FirstOrDefaultAsync(x => x.CategoryName == categoryName);
            if (check != null)
            {
                var res = _appDbContext.Categories.Remove(check);
                
                if (res != null)
                {
                    var ss = await _appDbContext.SaveChangesAsync();
                    if (ss > 0) return true;
                }
                else return false;
            }
            return false;
        }

        public async Task<List<Category>> GetAllAsync(long sid, long Eid)
        {
            var result = await _appDbContext.Categories.Where(x => x.StoreId == sid && x.EmployeeId == Eid).OrderByDescending(x => x.CreatedAt).ToListAsync();
            if (result is not null) return result.ToList();
            else return null;
        }

        public async Task<long> GetByNameAsync(string name)
        {
            var result = await _appDbContext.Categories.FirstOrDefaultAsync(x => x.CategoryName == name);
            if (result is not null)
            {
                return result.Id;
            }
            else return 0;
        }

        public async Task<string> UpdateAsync(CategoryDto category, string name)
        {
            var checkname = await _appDbContext.Categories.FirstOrDefaultAsync(x => x.CategoryName == category.CategoryName);
            if (checkname is null)
            {
                var entity = await _appDbContext.Categories.FirstOrDefaultAsync(x => x.CategoryName == name);
                if (entity != null)
                {
                    entity.CategoryName = category.CategoryName;
                    var res = await _appDbContext.SaveChangesAsync();
                    if (res > 0) { return "true"; }
                    else { return "false"; }
                }
                return "false";
            }
            else return "Category already exists, please try another name";
        }
    }
}
