using mag_app.Domain.Entities.SubCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Domain.Entities.AllProducts
{
    public class AllProducts
    {
        public string ProdutName { get; set; } = string.Empty;
        public string Barcode { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal PurchasedPrice { get; set; }
        public int Quantity { get; set; }
        public long StoreId { get; set; }
    }
}
