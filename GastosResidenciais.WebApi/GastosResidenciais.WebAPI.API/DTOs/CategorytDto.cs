using GastosResidenciais.WebApi.Domain.Enums;

namespace GastosResidenciais.WebApi.API.DTOs;

public class CategoryDto
{
    public string Description { get; set; }
    public CategoryPurpose Purpose { get; set; }
}