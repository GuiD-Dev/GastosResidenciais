using HomeFinances.WebApi.API.DTOs;
using HomeFinances.WebApi.Domain.Entities;

namespace HomeFinances.WebApi.API.Interfaces;

public interface ITransactionService
{
    IEnumerable<TransactionDto> ListTransactions();
    Transaction GetTransaction(int id);
    TransactionDto InsertTransaction(TransactionDto dto);
    bool DeleteTransaction(int id);
}