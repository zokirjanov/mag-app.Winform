using mag_app.Domain.Common;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Domain.Entities.SubCategories
{
    public class SubCategory : Auditable
    {
        public string SubCategoryName { get; set; } = string.Empty;
        public long EmployeeId { get; set; }
        public long StoreId { get; set; }
        public long CategoryId { get; set; }
        public virtual Category Category { get; set; } = default!;
        public List<Product> Products { get; set; }
    }
}
