using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Dtos.Stores
{
    public class AddStoreDto
    {
        public string StoreName { get; set; } = string.Empty;
        public long EmployeeCount { get; set; }

        public static implicit operator Store(AddStoreDto storeDto)
        {
            return new Store()
            {
                StoreName = storeDto.StoreName,
                EmployeeCount = storeDto.EmployeeCount,
                CreatedAt = TimeHelper.CurrentTime(),
                UpdatedAt = TimeHelper.CurrentTime()
            };
        }
    }
}
