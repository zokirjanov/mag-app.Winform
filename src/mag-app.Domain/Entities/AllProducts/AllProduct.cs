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
    public class AllProduct 
    {

        public long Id { get; set; }
        public string ProdutName { get; set; } = string.Empty;
        public string Barcode { get; set; } = string.Empty;


        [ForeignKey(nameof(StoreId))]
        public Store Store { get; set; } = default!;
        public long StoreId { get; set; }
        public string StoreName { get; set; } = string.Empty;


        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = default!;
        public long CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;


        [ForeignKey(nameof(SubCategoryId))]
        public SubCategory SubCategory { get; set; } = default!;
        public long SubCategoryId { get; set; }
        public string SubCategoryName { get; set; } = string.Empty;

        public int Quantity { get; set; }
        public decimal PurchasedPrice { get; set; }
        public decimal Price { get; set; }

    }
}
