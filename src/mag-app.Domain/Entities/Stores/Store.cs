﻿using mag_app.Domain.Common;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Domain.Entities.Stores
{
    public class Store : IAuditable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id  { get; set; }
        public string StoreName { get; set; } = string.Empty;
        public virtual ICollection<AllProduct> AllProducts { get; set; }
        public virtual ICollection<Cash> Cashes { get; set; }
        public virtual ICollection<SaleDetail> SalesGlobal { get; set; }

    }
}
