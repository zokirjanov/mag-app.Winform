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

        
        [ForeignKey("TabControllerId")]
        public TabController TabController { get; set; }

        public long TabControllerId { get; set; }
        public string TabControllerName { get; set; }


        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public long ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
