using mag_app.DataAccess.Interfaces.Products;
using mag_app.DataAccess.Repositories.Products;
using mag_app.Domain.Entities.Products;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Interfaces.Products;
using mag_app.Service.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Services.ProductService
{
    public class ReturnProductService : IReturnProductService
    {
        IReturnProductRepository _repository { get; set; }

        public ReturnProductService()
        {
            _repository = new ReturnProductRepository();
        }
        
        
      
        public async Task<ReturnProduct> CreateProductAsync(ReturnProductViewModel product)
        {
            return await _repository.CreateAsync(product);
        }

      
        
        public Task<bool> DeleteAsync(long Id)
        {
            throw new NotImplementedException();
        }

     
        
        public Task<ReturnProduct> Get(string barcode)
        {
            throw new NotImplementedException();
        }

      
        
        public Task<IEnumerable<ReturnProduct>> GetAllAsync(long Id)
        {
            throw new NotImplementedException();
        }

      
        
        public Task<IEnumerable<ReturnProduct>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
