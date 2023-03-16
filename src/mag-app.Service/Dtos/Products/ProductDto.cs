using mag_app.Domain.Entities.Products;
using mag_app.Service.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Dtos.Products
{
    public class ProductDto
    {
        public string ProdutName { get; set; } = string.Empty;
        public decimal Quantity { get; set; }
        public double Price { get; set; }
        public double PurchasedPrice { get; set; }
        public string Description { get; set; } = string.Empty;
        public long SubCategoryId { get; set; }
        public long CategoryId { get; set; }
        public long EmployeeId { get; set; }
        public static implicit operator Product(ProductDto productDto)
        {
            return new Product()
            {
                ProdutName = productDto.ProdutName,
                Quantity = productDto.Quantity,
                Price = productDto.Price,
                PurchasedPrice = productDto.PurchasedPrice,
                Description = productDto.Description,
                CategoryId = productDto.CategoryId,
                SubCategoryId = productDto.SubCategoryId,
                EmployeeId = productDto.EmployeeId,
                CreatedAt = TimeHelper.CurrentTime(),
                UpdatedAt = TimeHelper.CurrentTime()
            };
        }
    }
}
