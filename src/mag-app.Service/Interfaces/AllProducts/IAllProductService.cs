﻿using mag_app.Domain.Entities.AllProducts;
using mag_app.Domain.Entities.Products;
using mag_app.Service.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Interfaces.AllProducts
{
    public interface IAllProductService
    {
        public Task<AllProduct> CreateAllProductAsync(AllProduct product);
        public Task<IEnumerable<AllProduct>> GetAllAsync(long cId);
        public Task<bool> DeleteAsync(AllProduct product);
        public Task<(string message, AllProduct product)> UpdateAsync(AllProduct product);
        public Task<long> GetById(long pid, long cid);
        public Task<IEnumerable<AllProduct>> GetByNameAsync(string name, int quantity);
    }
}

