using mag_app.Domain.Common;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Stores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Domain.Entities.Products
{
    public class ReturnProduct : IAuditable
    {
        [Column(Order =0)]
        public long Id { get ; set; }


        [Column(Order =1)]
        public string Barcode { get; set; }


        [Column(Order =2)]
        public string Category { get; set; }


        [Column(Order =3)]
        public string SubCategory { get; set; }
        

        [Column(Order =4)]
        [ForeignKey("SaleGlobalId")]
        public long SaleGlobalId { get; set; }
        public virtual SaleGlobal SaleGlobal { get; set; }


        [Column(Order = 5)]
        public string SgName { get; set; }


        [Column(Order =6)]
        public decimal Quantity { get; set; }


        [Column(Order =7)]
        public decimal ReturnedPrice { get; set; }


        [Column(Order =8)]
        public DateTime ReturnDate { get; set; }
    }
}
