using mag_app.Domain.Common;
using mag_app.Domain.Constant;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mag_app.Domain.Entities.Stores
{
    public class SalesGlobal : IAuditable
    {
        [Column(Order = 1)]
        public long Id { get; set; }


        [Column(Order = 2)]
        public long StoreId { get; set; }
        [ForeignKey("StoreId")]
        public virtual Store Store { get; set; }


        [Column(Order = 3)]
        public string StoreName { get; set; }


        [Column(Order = 4)]
        public long CashId { get; set; }
        [ForeignKey("CashId")]
        public virtual Cash Cash { get; set; }



        [Column(Order = 5)]
        public string CashName { get; set; }


        [Column(Order = 6)]
        [EnumDataType(typeof(PaymentType))]
        public  PaymentType? PaymentType { get; set; } = null;


        [Column(Order = 7)]
        public decimal? CashAmount { get; set; }


        [Column(Order = 8)]
        public decimal? CardAmount { get; set; }


        [Column(Order = 9)]
        public decimal TotalSalePrice { get; set; }


        [Column(Order = 10)]
        public DateTime TransactionDate { get; set; }


        public virtual ICollection<SaleDetail> SaleDetails { get; set; }

    }
}
