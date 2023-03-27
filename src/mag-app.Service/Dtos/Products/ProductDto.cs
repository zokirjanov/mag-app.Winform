using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.SubCategories;
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
        public decimal Price { get; set; }
        public decimal PurchasedPrice { get; set; }
        public string Barcode { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public long CategoryId { get; set; }
        public string SubcategoryName { get; set; } = string.Empty;
        public long SubCategoryId { get; set; }
        public DateTime UpdatedAt { get; set; }

        public static implicit operator Product(ProductDto productDto)
        {
            return new Product()
            {
                ProdutName = productDto.ProdutName,
                Price = productDto.Price,
                PurchasedPrice = productDto.PurchasedPrice,
                Barcode = productDto.Barcode,
                CategoryName= productDto.CategoryName,
                CategoryId= productDto.CategoryId,
                SubcategoryName= productDto.SubcategoryName,
                SubCategoryId = productDto.SubCategoryId,
                CreatedAt = TimeHelper.CurrentTime(),
                UpdatedAt = productDto.UpdatedAt,
            };
        }
    }
}
