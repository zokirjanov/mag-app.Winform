using mag_app.Domain.Common;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Stores;

namespace mag_app.Domain.Entities.Products
{
    public class Product : Auditable
    {
        public string ProdutName { get; set; } = string.Empty;
        public long CategoryId { get; set; }
        public long  EmployeeId { get; set; }
    }
}
