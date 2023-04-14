using mag_app.Domain.Constant;
using mag_app.Domain.Entities.AllProducts;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.ViewModels.Stores
{
    public class SaleGlobalViewModel
    {
        public long SaleId { get; set; }

        public long ProductId { get; set; }
        public string ProductName { get; set; }

        public decimal Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal? DiscountPrice { get; set; }
        public string Barcode { get; set; }

        public static implicit operator SaleGlobal(SaleGlobalViewModel saleGlobalViewModel)
        {
            return new SaleGlobal()
            {
                SaleId= saleGlobalViewModel.SaleId,
                ProductId= saleGlobalViewModel.ProductId,
                ProductName= saleGlobalViewModel.ProductName,
                Quantity = saleGlobalViewModel.Quantity,
                Price= saleGlobalViewModel.Price,
                DiscountPrice= saleGlobalViewModel.DiscountPrice,
                Barcode = saleGlobalViewModel.Barcode
            };
        }
    }
}
