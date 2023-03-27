using mag_app.Domain.Common;
using mag_app.Domain.Entities.AllProducts;
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

        public decimal Price { get; set; }
        public decimal PurchasedPrice { get; set; }

        public string Barcode { get; set; } = string.Empty;

        public string CategoryName { get; set; } = string.Empty;
        public long CategoryId { get; set; }

        public string SubcategoryName { get; set; } = string.Empty;
        public long SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; } = default!;

        public List<AllProduct> AllProducts { get; set; } = default!;
    }
}

