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
        public int Quantity { get; set; }
        public decimal  Price { get; set; }
        public string Barcode { get; set; }
        public decimal PurchasedPrice { get; set; }
        public long SubCategoryId { get; set; }
        public long StoreId { get; set; }
        public long EmployeeId { get; set; }
        public DateTime UpdatedAt { get; set; }

        public static implicit operator Product(ProductDto productDto)
        {
            return new Product()
            {
                ProdutName = productDto.ProdutName,
                Quantity = productDto.Quantity,
                Price = productDto.Price,
                Barcode= productDto.Barcode,
                PurchasedPrice = productDto.PurchasedPrice,
                StoreId = productDto.StoreId,
                SubCategoryId = productDto.SubCategoryId,
                EmployeeId = productDto.EmployeeId,
                CreatedAt = TimeHelper.CurrentTime(),
                UpdatedAt = productDto.UpdatedAt,
            };
        }
    }
}
