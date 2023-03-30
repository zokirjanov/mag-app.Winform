using mag_app.Domain.Entities.AllProducts;
using mag_app.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Dtos.Products
{
    public class AllProductViewModel
    {
        public string ProdutName { get; set; } = string.Empty;

        public decimal PurchasedPrice { get; set; }
        public decimal Price { get; set; }

        public int Quantity { get; set; }
        public string Barcode { get; set; } = string.Empty;

        public string Storename { get; set; } = string.Empty;
        public long StoreId { get; set; }

        public string CategoryName { get; set; } = string.Empty;
        public long CategoryId { get; set; }

        public string SubcategoryName { get; set; } = string.Empty;
        public long SubCategoryId { get; set; }


        public static implicit operator AllProduct(AllProductViewModel product)
        {
            return new AllProduct()
            {
                ProdutName = product.ProdutName,
                Price = product.Price,
                PurchasedPrice = product.PurchasedPrice,
                Barcode = product.Barcode,
                Quantity = product.Quantity,
                CategoryName = product.CategoryName,
                CategoryId = product.CategoryId,
                SubCategoryName = product.SubcategoryName,
                SubCategoryId = product.SubCategoryId,
            };
        }
    }
}
