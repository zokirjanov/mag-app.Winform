using mag_app.Domain.Common;
using mag_app.Domain.Constant;
using mag_app.Domain.Entities.AllProducts;
using mag_app.Domain.Entities.Products;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace mag_app.Domain.Entities.Stores
{
    [DisplayName("Sale Global")]

    public class SaleGlobal : IAuditable
    {

        [Column(Order = 1)]
        public long Id { get; set; }

        [Column(Order = 2)]
        public string Barcode { get; set; }


        [Column(Order = 3)]
        public long SaleId { get; set; }
        [ForeignKey("SaleId")]
        public virtual SaleDetail SalesGlobal { get; set; } = default!;


        [Column(Order = 4)]
        public long ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual AllProduct AllProduct { get; set; } = default!;


        [Column(Order = 5)]
        public string ProductName { get; set; } = string.Empty;


        [Column(Order = 6)]
        public decimal Quantity { get; set; }


        [Column(Order = 7)]
        public decimal Price { get; set; }


        [Column(Order = 8)]
        public decimal? DiscountPrice { get; set; }


        public virtual ICollection<ReturnProduct> ReturnProducts { get; set; }

    }
}
