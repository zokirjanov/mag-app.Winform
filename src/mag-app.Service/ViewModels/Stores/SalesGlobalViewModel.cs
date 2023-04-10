﻿using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Stores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.ViewModels.Stores
{
    public class SalesGlobalViewModel
    {
        public decimal TotalSale { get; set; }

        public DateTime TransactionDate { get; set; }

        public long StoreId { get; set; }
        public string StoreName { get; set; }

        public long CashId { get; set; }
        public string CashName { get; set; }

        public static implicit operator SalesGlobal(SalesGlobalViewModel salesGlobalViewModel)
        {
            return new SalesGlobal()
            {
                TotalSale = salesGlobalViewModel.TotalSale,
                TransactionDate = TimeHelper.CurrentTime(),
                StoreId= salesGlobalViewModel.StoreId,
                StoreName= salesGlobalViewModel.StoreName,
                CashId= salesGlobalViewModel.CashId,
                CashName= salesGlobalViewModel.CashName,
            };
        }
    }
}
