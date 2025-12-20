using GastosResidenciais.WebApi.Domain.Enums;

namespace GastosResidenciais.WebApi.Domain.Entities;

public class Transaction
{
    public int Id { get; set; }
    public required string Description { get; set; }
    public required decimal Value { get; set; }
    public required TransactionType Type { get; set; }
    public required Category Category { get; set; }
    public required Person Person { get; set; }

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
    }
}
