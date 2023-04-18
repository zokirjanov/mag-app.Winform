using mag_app.Domain.Common;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Products;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;

namespace mag_app.Domain.Entities.SubCategories
{
    public class SubCategory : IAuditable
    {
        public long Id { get; set; }
        public string SubCategoryName { get; set; } = string.Empty;


        [ForeignKey("CategoryId")]
        public long CategoryId { get; set; }
        public virtual Category Category { get; set; } = default!;
        public string CategoryName { get; set; }


        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<AllProduct> AllProducts { get; set; }

    }
}
