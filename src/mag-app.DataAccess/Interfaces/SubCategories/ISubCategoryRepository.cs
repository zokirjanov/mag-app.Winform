using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.SubCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.DataAccess.Interfaces.SubCategories
{
    public interface ISubCategoryRepository : IGenericRepository<SubCategory>
    {
    }
}
