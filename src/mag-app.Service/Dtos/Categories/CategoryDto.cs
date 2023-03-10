using mag_app.Domain.Entities.Categories;
using mag_app.Service.Common.Helpers;

namespace mag_app.Service.Dtos.Categories
{
    public class CategoryDto
    {
        public string CategoryName { get; set; } = string.Empty;

        public long EmployeeId { get; set; }

        public long StoreId { get; set; }


        public static implicit operator Category(CategoryDto categoryDto)
        {
            return new Category()
            {
                CategoryName = categoryDto.CategoryName,
                EmployeeId = categoryDto.EmployeeId,
                StoreId = categoryDto.StoreId,
                CreatedAt = TimeHelper.CurrentTime(),
                UpdatedAt = TimeHelper.CurrentTime()
            };
        }
    }
}
