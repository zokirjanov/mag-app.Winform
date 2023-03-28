using mag_app.Domain.Common;
using mag_app.Domain.Entities.AllProducts;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Domain.Entities.Stores
{
    public class Store : Auditable
    {
        public string StoreName { get; set; } = string.Empty;
        public long UserId { get; set; }
        public virtual User User { get; set; } = default!;
        public List<Category> Categories { get; set; } = default!;
        public List<AllProduct> AllProducts { get; set; } = default!;
    }
}
