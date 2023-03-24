﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Common.Helpers
{
    public class IdentitySingelton
    {
        public long UserId { get; private set; }
        public long StoreId { get; private set; }

        private static IdentitySingelton _identitySingelton = default!;
        private IdentitySingelton()
        {
        }
        public static void BuildInstance(long userId)
        {
            if (_identitySingelton is null)
            {
                _identitySingelton = new IdentitySingelton();
                _identitySingelton.UserId = userId;
            }
            else throw new Exception("Is not null Instance");
        }

        public static void BuildStoreInstance(long storeid)
        {
            if (_identitySingelton is null)
            {
                _identitySingelton = new IdentitySingelton();
                _identitySingelton.StoreId = storeid;
            }
            else throw new Exception("Is not null Instance");
        }

        public static IdentitySingelton GetInstance()
        {
            return _identitySingelton;
        }
    }
}
