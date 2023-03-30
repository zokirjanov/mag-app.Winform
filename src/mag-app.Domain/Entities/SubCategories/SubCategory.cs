using mag_app.Domain.Common;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Domain.Entities.SubCategories
{
    public class SubCategory : IAuditable
    {
        public long Id { get; set; }
        public string SubCategoryName { get; set; } = string.Empty;


        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = default!;
        public long CategoryId { get; set; }
    }
}
