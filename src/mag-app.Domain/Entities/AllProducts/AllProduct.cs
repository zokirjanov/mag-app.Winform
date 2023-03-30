using mag_app.Domain.Common;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Stores;
using mag_app.Domain.Entities.SubCategories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Domain.Entities.AllProducts
{
    public class AllProduct : IAuditable
    {
        public long Id  { get; set; }
        public int Quantity { get; set; }


        [ForeignKey(nameof(StoreId))] 
        public Store Store { get; set; } = default!;
        public long StoreId { get; set; }


        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = default!;
        public string CategoryName { get; set; } = string.Empty;
        public long CategoryId { get; set; }



        [ForeignKey(nameof(SubcategoryId))] 
        public SubCategory SubCategory { get; set; } = default!;
        public string SubCategoryName { get; set; } = string.Empty;
        public long SubcategoryId { get; set; }

    }
}
