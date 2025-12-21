using GastosResidenciais.WebApi.Domain.Entities;

namespace GastosResidenciais.WebApi.Application.Interfaces;

public interface ITransactionRepository
{
    IEnumerable<Transaction> GetMany();
    Transaction GetOneById(int id);
    Transaction Insert(Transaction transaction);
    bool Delete(int id);
}