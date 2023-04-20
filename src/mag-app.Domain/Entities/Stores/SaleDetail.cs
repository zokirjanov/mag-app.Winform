using mag_app.Domain.Common;
using mag_app.Domain.Constant;
using mag_app.Domain.Entities.Products;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mag_app.Domain.Entities.Stores
{
    [DisplayName("Sale Details")]
    public class SaleDetail : IAuditable
    {
        [Column(Order = 1)]
        public long Id { get; set; }

        [Column(Order = 2)]
        public string CheckNumber { get; set; }

        [Column(Order = 3)]
        public long CashId { get; set; }
        [ForeignKey("CashId")]
        public virtual Cash Cash { get; set; }


        [Column(Order = 4)]
        public string CashName { get; set; }


        [Column(Order = 5)]
        [EnumDataType(typeof(PaymentType))]
        public  PaymentType? PaymentType { get; set; } = null;


        [Column(Order = 6)]
        public decimal? CashAmount { get; set; }


        [Column(Order = 7)]
        public decimal? CardAmount { get; set; }


        [Column(Order = 8)]
        public decimal TotalSalePrice { get; set; }


        [Column(Order = 9)]
        public decimal change { get; set; }

        [Column(Order = 10)]
        public decimal? DiscountPrice { get; set; }

        [Column(Order = 11)]
        public DateTime TransactionDate { get; set; }



        [Column(Order = 12)]
        public long StoreId { get; set; }
        [ForeignKey("StoreId")]
        public virtual Store Store { get; set; }


        [Column(Order = 13)]
        public string StoreName { get; set; }


        [Column(Order = 14)]
        public long? IsReturned { get; set; }

        public virtual ICollection<SaleGlobal> SaleDetails { get; set; }

    }
}
