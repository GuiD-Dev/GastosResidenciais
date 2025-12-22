using GastosResidenciais.WebApi.Domain.Entities;
using GastosResidenciais.WebApi.Domain.Enums;

namespace GastosResidenciais.WebApi.API.DTOs;

public class CategoryDto
{
    public string Description { get; set; }
    public CategoryPurpose Purpose { get; set; }

    public static explicit operator Category(CategoryDto dto)
    {
        return new Category
        {
            Description = dto.Description,
            Purpose = dto.Purpose,
        };
    }

    public static explicit operator CategoryDto(Category entity)
    {
        return new CategoryDto
        {
            Description = entity.Description,
            Purpose = entity.Purpose,
        };
    }
}