using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GastosResidenciais.WebApi.Domain.Enums;

namespace GastosResidenciais.WebApi.Domain.Entities;

[Table("transaction")]
public class Transaction
{
    [Column("id"), Key]
    public int Id { get; set; }

    [Column("description"), Required]
    public string Description { get; set; }

    [Column("value"), Required]
    public decimal Value { get; set; }

    [Column("type"), Required]
    public TransactionType Type { get; set; }

    [Column("category"), Required]
    public Category Category { get; set; }

    [Column("person"), Required]
    public Person Person { get; set; }

    // Used by EntityFramework
    private Transaction() { }

    public Transaction(string description, decimal value, TransactionType type, Category category, Person person)
    {
        if (
            Category?.Purpose == CategoryPurpose.Recipe && Type == TransactionType.Expense
            ||
            Category?.Purpose == CategoryPurpose.Expense && Type == TransactionType.Recipe
        )
        {
            throw new Exception("Transaction Type and Category are incompatible");
        }

        Description = description;
        Value = value;
        Type = type;
        Category = category;
        Person = person;

    }
}
