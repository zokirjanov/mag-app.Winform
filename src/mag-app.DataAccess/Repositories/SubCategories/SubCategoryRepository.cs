﻿using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces.Categories;
using mag_app.DataAccess.Interfaces.SubCategories;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.SubCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.DataAccess.Repositories.SubCategories
{
    public class SubCategoryRepository : GenericRepository<SubCategory>, ISubCategoryRepository
    {
    }
}
