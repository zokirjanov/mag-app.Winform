using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Domain.Common
{
    public interface IAuditable
    {
        public long Id  { get; set; }
    }
}
