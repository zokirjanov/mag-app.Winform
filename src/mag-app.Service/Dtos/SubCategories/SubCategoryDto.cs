using mag_app.Domain.Entities.SubCategories;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Categories;

namespace mag_app.Service.Dtos.SubCategories
{
    public class SubCategoryDto
    {
        public string SubCategoryName { get; set; } = string.Empty;
        public long CategoryId { get; set; }
        public long StoreId { get; set; }
        public long EmployeeId { get; set; }

        public static implicit operator SubCategory(SubCategoryDto subCategoryDto)
        {
            return new SubCategory()
            {
                SubCategoryName= subCategoryDto.SubCategoryName,
                EmployeeId = subCategoryDto.EmployeeId,
                CategoryId = subCategoryDto.CategoryId,
                StoreId= subCategoryDto.StoreId,
                CreatedAt = TimeHelper.CurrentTime(),
                UpdatedAt = TimeHelper.CurrentTime()
            };
        }
    }
}
