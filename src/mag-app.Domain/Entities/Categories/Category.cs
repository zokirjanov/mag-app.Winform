using mag_app.Domain.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Domain.Entities.Categories
{
    public class Category : Auditable
    {
        public string CategoryName { get; set; } = string.Empty;

        public long EmployeeId { get; set; }
    }
}
