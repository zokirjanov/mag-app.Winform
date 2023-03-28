using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Dtos.Products
{
    public class AllProductViewMode
    {
        public string ProdutName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal PurchasedPrice { get; set; }
        public int Quantity { get; set; }
        public string Barcode { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public string SubcategoryName { get; set; } = string.Empty;
    }
}
