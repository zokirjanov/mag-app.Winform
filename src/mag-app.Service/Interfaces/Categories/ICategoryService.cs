﻿using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Products;
using mag_app.Service.Dtos.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Interfaces.Categories
{
    public interface ICategoryService
    {
        public Task<string> CreateCategoryAsync(CategoryViewModel category);
        public Task<List<Category>> GetAllAsync(long Eid);
        public Task<bool> DeleteAsync(string categoryName);
        public Task<string> UpdateAsync(CategoryViewModel category, string name);
        public Task<long> GetByNameAsync(string name);
    }
}
