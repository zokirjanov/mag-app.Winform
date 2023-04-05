using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Domain.Entities.Stores
{
    public class TabController
    {
        public long Id { get; set; }
        public string TabName { get; set; } = string.Empty;
        public virtual ICollection<TabProduct> TabProducts { get; set; }
    }
}
