using mag_app.DataAccess.Interfaces.Products;
using mag_app.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.DataAccess.Repositories.Products
{
    public class ReturnProductRepository :  GenericRepository<ReturnProduct>, IReturnProductRepository
    {
    }
}
