﻿using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Dtos.Stores
{
    public class StoreViewModel
    {
        public string StoreName { get; set; } = string.Empty;

        public static implicit operator Store(StoreViewModel storeDto)
        {
            return new Store()
            {
                StoreName = storeDto.StoreName,
            };
        }
    }
}
