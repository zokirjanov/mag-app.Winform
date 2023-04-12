using mag_app.Domain.Common;
using mag_app.Domain.Constant;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mag_app.Domain.Entities.Stores
{
    [DisplayName("Sale Details")]
    public class SalesGlobal : IAuditable
    {
        [Column(Order = 1)]
        public long Id { get; set; }


        [Column(Order = 2)]
        public long CashId { get; set; }
        [ForeignKey("CashId")]
        public virtual Cash Cash { get; set; }


        [Column(Order = 3)]
        public string CashName { get; set; }


        [Column(Order = 4)]
        [EnumDataType(typeof(PaymentType))]
        public  PaymentType? PaymentType { get; set; } = null;


        [Column(Order = 5)]
        public decimal? CashAmount { get; set; }


        [Column(Order = 6)]
        public decimal? CardAmount { get; set; }


        [Column(Order = 7)]
        public decimal TotalSalePrice { get; set; }

        public decimal change { get; set; }


        [Column(Order = 8)]
        public DateTime TransactionDate { get; set; }



        [Column(Order = 9)]
        public long StoreId { get; set; }
        [ForeignKey("StoreId")]
        public virtual Store Store { get; set; }


        [Column(Order = 10)]
        public string StoreName { get; set; }
        public virtual ICollection<SaleDetail> SaleDetails { get; set; }

    }
}
