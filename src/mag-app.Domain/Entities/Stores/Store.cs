using mag_app.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Domain.Entities.Stores
{
    public class Store : Auditable
    {
        public string StoreName { get; set; } = string.Empty;
        public long EmployeeCount { get; set; }
        public long EmployeeId { get; set; }
    }
}
