using GastosResidenciais.WebApi.Application.Interfaces;
using GastosResidenciais.WebApi.Domain.Entities;
using GastosResidenciais.WebApi.Infra.Contexts;
using Microsoft.EntityFrameworkCore;

namespace GastosResidenciais.WebApi.Infra.Repositories;

public class TransactionRepository(PgSqlDbContext context) : ITransactionRepository
{
    public IEnumerable<Transaction> GetMany()
    {
        return context.Transactions
                        .Include(t => t.Person)
                        .Include(t => t.Category)
                        .ToList();
    }

    public Transaction GetOneById(int id)
    {
        throw new NotImplementedException();
    }

    public Transaction Insert(Transaction transaction)
    {
        context.Transactions.Add(transaction);
        context.SaveChanges();
        return transaction;
    }

    public bool Delete(int id)
    {
        var transaction = context.Transactions.FirstOrDefault(p => p.Id == id);
        if (transaction is null)
            throw new Exception("Id not found");

        context.Transactions.Remove(transaction);
        context.SaveChanges();

        return true;
    }
}
