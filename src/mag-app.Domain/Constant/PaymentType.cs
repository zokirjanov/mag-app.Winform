using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mag_app.Domain.Constant
{
    public enum PaymentType
    {
        наличные,
        Терминал,
        частичная_оплата 
    }
}
