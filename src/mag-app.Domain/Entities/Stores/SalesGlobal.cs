using mag_app.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace mag_app.Domain.Entities.Stores
{
    public class SalesGlobal : IAuditable
    {
        public long Id { get; set; }

        public decimal TotalSale { get; set; }

        public DateTime TransactionDate { get; set; }


        public long StoreId { get; set; }
        [ForeignKey("StoreId")]
        public virtual Store Store { get; set; }
        public string StoreName { get; set; }



        public long CashId { get; set; }
        [ForeignKey("CashId")]
        public virtual Cash Cash { get; set; }
        public string CashName { get; set; }
        public virtual ICollection<SaleDetail> SaleDetails { get; set; }


    }
}
