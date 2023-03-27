﻿using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Products;
using mag_app.Service.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Interfaces.Products
{
    public interface IproductService
    {
        public Task<(string message, Product product)> CreateProductAsync(ProductDto product);
        public Task<IEnumerable<Product>> GetAllAsync(long cId);
        public Task<string> DeleteAsync(string name);
        public Task<string> UpdateAsync(ProductDto Product, string name);
        public Task<long> GetByNameAsync(string name);

    }
}
