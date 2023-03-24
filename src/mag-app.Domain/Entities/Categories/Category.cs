using mag_app.Domain.Common;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Stores;
using mag_app.Domain.Entities.SubCategories;
using mag_app.Domain.Entities.Users;

namespace mag_app.Domain.Entities.Categories
{
    public class Category : Auditable
    {
        public string CategoryName { get; set; } = string.Empty;
        public long EmployeeId { get; set; }
        public long StoreId { get; set; }
        public virtual Store Store { get; set; } = default!;
        public List<SubCategory> SubCategories { get; set; } = default!;
    }
}
