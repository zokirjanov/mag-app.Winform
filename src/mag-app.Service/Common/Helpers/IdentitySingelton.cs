using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Common.Helpers
{
    public class IdentitySingelton
    {
        public long EmployeeId { get; private set; }

        private static IdentitySingelton _identitySingelton;
        private IdentitySingelton()
        {
        }
        public static void BuildInstance(long userId)
        {
            if (_identitySingelton is null)
            {
                _identitySingelton = new IdentitySingelton();
                _identitySingelton.EmployeeId = userId;
            }
            else throw new Exception("Is not null Instance");
        }
        public static IdentitySingelton GetInstance()
        {
            return _identitySingelton;
        }
    }
}
