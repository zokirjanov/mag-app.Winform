
using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces.SubCategories;
using mag_app.Domain.Entities.Categories;
using mag_app.Service.Dtos.Categories;
using mag_app.Service.Interfaces.SubCategories;
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


        public Task<string> CreateCategoryAsync(CategoryDto category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
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
