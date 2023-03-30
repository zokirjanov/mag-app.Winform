using mag_app.Domain.Common;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.SubCategories;
using System.ComponentModel.DataAnnotations.Schema;

namespace mag_app.Domain.Entities.Products
{
    public class Product : IAuditable
    {
        public long Id { get; set; }
        public string ProdutName { get; set; } = string.Empty;

        public decimal PurchasedPrice { get; set; }
        public decimal Price { get; set; }

        public string Barcode { get; set; } = string.Empty;
        public int Quantity { get; set; }


        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = default!;
        public string CategoryName { get; set; } = string.Empty;
        public long CategoryId { get; set; }


        [ForeignKey(nameof(SubCategoryId))]
        public SubCategory SubCategory { get; set; } = default!;
        public string SubCategoryName { get; set; } = string.Empty;
        public long SubCategoryId { get; set; }



        

    }
}

