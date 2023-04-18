using mag_app.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Domain.Entities.Stores
{
    public class TabProduct
    {
        public long Id { get; set; }
        public decimal Price { get; set; }
        public string Barcode { get; set; }
        public decimal Quantity { get; set; }



        [ForeignKey("TabControllerId")]
        public virtual TabController TabController { get; set; }

        public long TabControllerId { get; set; }
        public string TabControllerName { get; set; }


        [ForeignKey("ProductId")]
        public virtual AllProduct AllProduct { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
