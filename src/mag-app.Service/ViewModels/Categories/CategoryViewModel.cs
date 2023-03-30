using mag_app.Domain.Entities.Categories;
using mag_app.Service.Common.Helpers;

namespace mag_app.Service.Dtos.Categories
{
    public class CategoryViewModel
    {
        public string CategoryName { get; set; } = string.Empty;

        public static implicit operator Category(CategoryViewModel categoryDto)
        {
            return new Category()
            {
                CategoryName = categoryDto.CategoryName
            };
        }
    }
}
