using mag_app.Domain.Common;
using mag_app.Domain.Entities.Categories;
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
    public class AllProduct : Product
    {
        [ForeignKey(nameof(StoreId))]
        public Store Store { get; set; } = default!;
        public string StoreName { get; set; } = string.Empty;
        public long StoreId { get; set; }
    }
}
