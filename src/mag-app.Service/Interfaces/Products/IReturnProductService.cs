using mag_app.Domain.Entities.Products;
using mag_app.Service.Dtos.Products;
using mag_app.Service.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Interfaces.Products
{
    public interface IReturnProductService
    {
        public Task<ReturnProduct> CreateProductAsync(ReturnProductViewModel product);
        public Task<IEnumerable<ReturnProduct>> GetAllAsync(long Id);
        public Task<IEnumerable<ReturnProduct>> GetAllAsync();
        public Task<ReturnProduct> Get(string barcode);
        public Task<bool> DeleteAsync(long Id);
    }
}
