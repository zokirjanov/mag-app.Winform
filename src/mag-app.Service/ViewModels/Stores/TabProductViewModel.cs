using mag_app.Domain.Entities.Stores;
using mag_app.Service.Dtos.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.ViewModels.Stores
{
    public class TabProductViewModel
    {
        public string Category{ get; set; }
        public string SubCategory { get; set; }
        public long ProductId { get; set; }
        public decimal Price { get; set; }
        public string ProductName { get; set; }
        public long TabControllerId { get; set; }
        public string Barcode { get; set; }
        public decimal Quantity { get; set; }
        public string TabControllerName { get; set; }


        public static implicit operator TabProduct(TabProductViewModel tabProduct)
        {
            return new TabProduct()
            {
                ProductId = tabProduct.ProductId,
                ProductName = tabProduct.ProductName,
                Category= tabProduct.Category,
                Subcategory = tabProduct.SubCategory,
                Quantity= tabProduct.Quantity,
                Barcode = tabProduct.Barcode,
                TabControllerId= tabProduct.TabControllerId,
                TabControllerName= tabProduct.TabControllerName,
                Price = tabProduct.Price
            };
        }
    }
}
