using mag_app.Domain.Entities.AllProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.DataAccess.Interfaces.AllProducts
{
    internal interface IAllProductRepository : IGenericRepository<AllProduct>
    {
    }
}
