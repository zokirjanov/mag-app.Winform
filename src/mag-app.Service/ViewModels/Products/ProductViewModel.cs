using mag_app.Domain.Entities.Products;

namespace mag_app.Service.Dtos.Products
{
    public class ProductViewModel
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

        public static implicit operator Product(ProductViewModel product)
        {
            return new Product()
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
