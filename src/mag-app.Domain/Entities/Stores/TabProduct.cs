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
        [Column(Order = 0)]
        public long Id { get; set; }

        [Column(Order = 1)]
        public string Barcode { get; set; }


        [Column(Order = 2)]
        public string Category { get; set; }


        [Column(Order = 3)]
        public string Subcategory { get; set; }




        [ForeignKey("ProductId")]
        public virtual AllProduct AllProduct { get; set; }
        [Column(Order =4)]
        public long ProductId { get; set; }
        [Column(Order = 5)]
        public string ProductName { get; set; }



        [ForeignKey("TabControllerId")]
        public virtual TabController TabController { get; set; }
        [Column(Order =6)]
        public long TabControllerId { get; set; }
        [Column(Order =7)]
        public string TabControllerName { get; set; }




        [Column(Order =8)]
        public decimal Price { get; set; }

    }
}
