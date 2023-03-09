using mag_app.Domain.Entities.Products;
using mag_app.Service.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Dtos.Products
{
    public class ProductDto
    {
        public string ProdutName { get; set; } = string.Empty;
        public long CategoryId { get; set; }
        public static implicit operator Product(ProductDto productDto)
        {
            return new Product()
            {
                ProdutName = productDto.ProdutName,
                CategoryId = productDto.CategoryId,
                CreatedAt = TimeHelper.CurrentTime(),
                UpdatedAt = TimeHelper.CurrentTime()
            };
        }
    }
}
