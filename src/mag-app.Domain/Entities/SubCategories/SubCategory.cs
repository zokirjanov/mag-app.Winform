using mag_app.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Domain.Entities.SubCategories
{
    public class SubCategory : Auditable
    {
        public string SubCategoryName { get; set; } = string.Empty;
        public long CategoryId { get; set; }
    }
}
