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
        public long ProductId { get; set; }
        public decimal Price { get; set; }

        public string ProductName { get; set; }

        public long TabControllerId { get; set; }

        public string TabControllerName { get; set; }


        public static implicit operator TabProduct(TabProductViewModel tabProduct)
        {
            return new TabProduct()
            {
                ProductId = tabProduct.ProductId,
                ProductName = tabProduct.ProductName,
                TabControllerId= tabProduct.TabControllerId,
                TabControllerName= tabProduct.TabControllerName,
                Price = tabProduct.Price
            };
        }
    }
}
