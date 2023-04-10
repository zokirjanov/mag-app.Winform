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
    public class SaleDetailsViewModel
    {
        public long SaleId { get; set; }

        public long ProductId { get; set; }
        public string ProductName { get; set; }

        public decimal Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal? DiscountPrice { get; set; }

        public PaymentType PaymentType { get; set; }

        public decimal? CashAmount { get; set; }

        public decimal? CardAmount { get; set; }

        public static implicit operator SaleDetail(SaleDetailsViewModel saleDetailsViewModel)
        {
            return new SaleDetail()
            {
                SaleId= saleDetailsViewModel.SaleId,
                ProductId= saleDetailsViewModel.ProductId,
                ProductName= saleDetailsViewModel.ProductName,
                Quantity = saleDetailsViewModel.Quantity,
                Price= saleDetailsViewModel.Price,
                DiscountPrice= saleDetailsViewModel.DiscountPrice,
                PaymentType= saleDetailsViewModel.PaymentType,
                CardAmount= saleDetailsViewModel.CardAmount,
                CashAmount= saleDetailsViewModel.CashAmount,
            };
        }
    }
}
