using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces.Categories;
using mag_app.Domain.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.DataAccess.Repositories.SubCategories
{
    public class SubCategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public SubCategoryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
