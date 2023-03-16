using mag_app.Domain.Common;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Stores;
using mag_app.Domain.Entities.SubCategories;
using mag_app.Domain.Entities.Users;
using System.Runtime;

namespace mag_app.Domain.Entities.Products
{
    public class Product : Auditable
    {
        public string ProdutName { get; set; } = string.Empty;
        public double Price { get; set; }
        public decimal  Quantity { get; set; }
        public string Description { get; set; } = string.Empty;
        public long SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; } = default!;
        public long  EmployeeId { get; set; }
        public long CategoryId { get; set; }
    }
}
