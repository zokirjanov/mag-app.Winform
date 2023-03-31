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
        public string Barcode { get; set; } 

        [ForeignKey("StoreId")]
        public virtual Store Store { get; set; }
        public long? StoreId { get; set; }
        public string? StoreName { get; set; } 


        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }
        public long CategoryId { get; set; }
        public string CategoryName { get; set; } 


        [ForeignKey("SubCategoryId")]
        public virtual SubCategory? SubCategory { get; set; }
        public long? SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }

        public string ProdutName { get; set; }
        public decimal PurchasedPrice { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }


    }
}
