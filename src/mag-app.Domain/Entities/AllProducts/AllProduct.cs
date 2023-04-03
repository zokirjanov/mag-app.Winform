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
        [Column(Order =1)]
        public long Id { get; set; }


        [Column(Order =2)]
        public string Barcode { get; set; } 


        [ForeignKey("StoreId")]
        public virtual Store Store { get; set; }


        [Column(Order =3)]
        public long? StoreId { get; set; }


        [Column(Order =4)]
        public string? StoreName { get; set; } 


        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }


        [Column(Order =5)]
        public long CategoryId { get; set; }


        [Column(Order =6)]
        public string CategoryName { get; set; } 


        [ForeignKey("SubCategoryId")]
        public virtual SubCategory? SubCategory { get; set; }


        [Column(Order =7)]
        public long? SubCategoryId { get; set; }


        [Column(Order =8)]
        public string SubCategoryName { get; set; }



        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }


        [Column(Order = 9)]
        public long ProductId { get; set; }


        [Column(Order =10)]
        public string ProdutName { get; set; }


        [Column(Order =11)]
        public decimal PurchasedPrice { get; set; }


        [Column(Order =12)]
        public decimal Price { get; set; }


        [Column(Order =13)]
        public int Quantity { get; set; }


    }
}
