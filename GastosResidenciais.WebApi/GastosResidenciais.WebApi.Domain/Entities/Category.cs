using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GastosResidenciais.WebApi.Domain.Enums;

namespace GastosResidenciais.WebApi.Domain.Entities;

[Table("category")]
public class Category
{
    [Column("id"), Key]
    public int Id { get; set; }

    [Column("description"), Required]
    public string Description { get; set; }
    
    [Column("purpose"), Required]
    public CategoryPurpose Purpose { get; set; }

    public Category(string description, CategoryPurpose purpose)
    {
        Description = description;
        Purpose = purpose;
    }
}