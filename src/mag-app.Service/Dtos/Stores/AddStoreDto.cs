using mag_app.Domain.Entities.Stores;
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
    public class AddStoreDto
    {
        [MaxLength(30)]
        public string StoreName { get; set; } = string.Empty;
        public long EmployeeID { get; set; }

        public static implicit operator Store(AddStoreDto storeDto)
        {
            return new Store()
            {
                StoreName = storeDto.StoreName,
                EmployeeId = storeDto.EmployeeID,
                CreatedAt = TimeHelper.CurrentTime(),
                UpdatedAt = TimeHelper.CurrentTime()
            };
        }
    }
}
