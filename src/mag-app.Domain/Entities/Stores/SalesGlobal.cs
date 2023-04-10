using mag_app.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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

        public long CashId { get; set; }
        [ForeignKey("CashId")]
        public virtual Cash Cash { get; set; }

        public string StoreName { get; set; }

        public string CashName { get; set; }

        public virtual ICollection<SaleDetail> SaleDetails { get; set; }


    }
}
