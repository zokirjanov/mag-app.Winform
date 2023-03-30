﻿using mag_app.DataAccess.DbContexts;
using mag_app.DataAccess.Interfaces.Categories;
using mag_app.Domain.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.DataAccess.Repositories.Categories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
    }
}
