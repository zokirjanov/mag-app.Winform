﻿using mag_app.Domain.Common;
using mag_app.Domain.Constant;
using mag_app.Domain.Entities.AllProducts;
using System.ComponentModel.DataAnnotations.Schema;

namespace mag_app.Domain.Entities.Stores
{
    public class SaleDetail : IAuditable
    {

        [Column(Order = 1)]
        public long Id { get; set; }



        [Column(Order = 2)]
        public long SaleId { get; set; }
        [ForeignKey("SaleId")]
        public virtual SalesGlobal SalesGlobal { get; set; }


        [Column(Order = 3)]
        public long ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual AllProduct AllProduct { get; set; }


        [Column(Order = 4)]
        public string ProductName { get; set; }


        [Column(Order = 5)]
        public decimal Quantity { get; set; }


        [Column(Order = 6)]
        public decimal Price { get; set; }


        [Column(Order = 7)]
        public decimal? DiscountPrice { get; set; }
    }
}
