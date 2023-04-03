using mag_app.Domain.Common;
using mag_app.Domain.Entities.AllProducts;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Stores;
using mag_app.Domain.Entities.SubCategories;
using System.ComponentModel.DataAnnotations.Schema;

namespace mag_app.Domain.Entities.Products
{
    public class Product : IAuditable
    {
        public long Id { get; set; }
        public string? Barcode { get; set; }


        [ForeignKey("CategoryId")]
        public long CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string CategoryName { get; set; }


        [ForeignKey("SubCategoryId")]
        public long SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public string SubCategoryName { get; set; }


        public string ProdutName { get; set; }
        public decimal PurchasedPrice { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public virtual ICollection<AllProduct> AllProducts { get; set; }

    }
}

