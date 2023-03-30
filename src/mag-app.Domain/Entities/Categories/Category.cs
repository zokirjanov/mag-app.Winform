using mag_app.Domain.Common;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Stores;
using mag_app.Domain.Entities.SubCategories;
using mag_app.Domain.Entities.Users;

namespace mag_app.Domain.Entities.Categories
{
    public class Category : IAuditable
    {
        public long Id { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }
}
