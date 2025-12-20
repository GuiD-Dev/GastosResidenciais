using GastosResidenciais.WebApi.Domain.Enums;

namespace GastosResidenciais.WebApi.Domain.Entities;

public class Category
{
    public int Id { get; set; }
    public required string Description { get; set; }
    public required CategoryPurpose Purpose { get; set; }

    public Category(string description, CategoryPurpose purpose)
    {
        Description = description;
        Purpose = purpose;
    }
}