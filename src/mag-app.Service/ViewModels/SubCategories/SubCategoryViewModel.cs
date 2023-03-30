using mag_app.Domain.Entities.SubCategories;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Categories;

namespace mag_app.Service.Dtos.SubCategories
{
    public class SubCategoryViewModel
    {
        public string SubCategoryName { get; set; } = string.Empty;
        public long CategoryId { get; set; }

        public static implicit operator SubCategory(SubCategoryViewModel subCategoryDto)
        {
            return new SubCategory()
            {
                SubCategoryName= subCategoryDto.SubCategoryName,
                CategoryId = subCategoryDto.CategoryId,
            };
        }
    }
}
