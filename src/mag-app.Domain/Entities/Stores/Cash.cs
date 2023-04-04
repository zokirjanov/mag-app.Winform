using mag_app.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Domain.Entities.Stores
{
    public class Cash : IAuditable
    {
        [Column(Order =0)]
        public long Id { get; set; }

        [ForeignKey("StoreId")]
        public Store Store { get; set; }

        [Column(Order =1)]
        public long StoreId { get; set; }

        [Column(Order =2)]
        public string StoreName { get; set; }

        [Column(Order =3)]
        public string CashName { get; set; }
    }
}
