using mag_app.Domain.Constant;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Stores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.ViewModels.Stores
{
    public class SaleDetailsViewModel
    {
        public long Id { get; set; }
        public decimal TotalSale { get; set; }

        public DateTime TransactionDate { get; set; }

        public long StoreId { get; set; }
        public string StoreName { get; set; }

        public long CashId { get; set; }
        public string CashName { get; set; }

        [EnumDataType(typeof(PaymentType))]
        public PaymentType PaymentType { get; set; }

        public decimal? CashAmount { get; set; }

        public decimal? CardAmount { get; set; }

        public decimal Change { get; set; }

        public decimal? Discount { get; set; }

        public static implicit operator SaleDetail(SaleDetailsViewModel saleDetailsViewModel)
        {
            return new SaleDetail()
            {
                TotalSalePrice = saleDetailsViewModel.TotalSale,
                TransactionDate = TimeHelper.CurrentTime(),
                StoreId= saleDetailsViewModel.StoreId,
                StoreName= saleDetailsViewModel.StoreName,
                CashId= saleDetailsViewModel.CashId,
                CashName= saleDetailsViewModel.CashName,
                PaymentType= saleDetailsViewModel.PaymentType,
                CardAmount= saleDetailsViewModel.CardAmount,    
                CashAmount= saleDetailsViewModel.CashAmount,
                change= saleDetailsViewModel.Change,
                DiscountPrice = saleDetailsViewModel.Discount
            };
        }
    }
}
