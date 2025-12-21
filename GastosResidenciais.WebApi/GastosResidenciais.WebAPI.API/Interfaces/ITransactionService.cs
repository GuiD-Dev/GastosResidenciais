using GastosResidenciais.WebApi.API.DTOs;
using GastosResidenciais.WebApi.Domain.Entities;

namespace GastosResidenciais.WebApi.API.Interfaces;

public interface ITransactionService
{
    IEnumerable<Transaction> ListTransactions();
    Transaction GetTransaction(int id);
    Transaction InsertTransaction(TransactionDto dto);
    bool DeleteTransaction(int id);
}