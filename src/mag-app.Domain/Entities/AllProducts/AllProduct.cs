using mag_app.Domain.Common;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Stores;
using mag_app.Domain.Entities.SubCategories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Domain.Entities.AllProducts
{
    public class AllProduct : Auditable
    {
        public int Quantity { get; set; }

        public long StoreId { get; set; }
        public virtual Store Stores { get; set; } = default!;

        public long  ProductId { get; set; }
        public virtual Product Products { get; set; } = default!;
    }
}
