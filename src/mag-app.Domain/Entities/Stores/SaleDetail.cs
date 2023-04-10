using mag_app.Domain.Common;
using mag_app.Domain.Constant;
using mag_app.Domain.Entities.AllProducts;
using System.ComponentModel.DataAnnotations.Schema;

namespace mag_app.Domain.Entities.Stores
{
    public class SaleDetails : IAuditable
    {
        public long Id { get; set; }

        public long SaleId { get; set; }
        [ForeignKey("SaleId")]
        public virtual SalesGlobal SalesGlobal { get; set; }

        public long ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual AllProduct AllProduct { get; set; }

        public string ProductName { get; set; }

        public decimal Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal? DiscountPrice { get; set; }

        public DateTime? DiscountStartDate { get; set; }

        public DateTime? DiscountEndDate { get; set; }

        public PaymentType PaymentType { get; set; } = PaymentType.Cash;

        public decimal? CashAmount { get; set; }

        public decimal? CardAmount { get; set; }

    }
}
