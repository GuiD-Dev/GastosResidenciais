using GastosResidenciais.WebApi.API.DTOs;
using GastosResidenciais.WebApi.API.Interfaces;
using GastosResidenciais.WebApi.Application.Interfaces;
using GastosResidenciais.WebApi.Domain.Entities;

namespace GastosResidenciais.WebApi.Application.Services;

public class TransactionService(IPersonRepository personRepository, ICategoryRepository categoryRepository, ITransactionRepository transactionRepository) : ITransactionService
{
    public IEnumerable<Transaction> ListTransactions()
    {
        return transactionRepository.GetMany();
    }

    public Transaction GetTransaction(int id)
    {
        return transactionRepository.GetOneById(id);
    }

    public Transaction InsertTransaction(TransactionDto dto)
    {
        var category = categoryRepository.GetOneById(dto.CategoryId);
        if (category is null)
            throw new Exception("Category not found");

        var person = personRepository.GetOneById(dto.PersonId);
        if (person is null)
            throw new Exception("Person not found");

        var transaction = new Transaction
        {
            Description = dto.Description,
            Value = dto.Value,
            Category = category,
            Type = dto.Type,
            Person = person,
        };

        return transactionRepository.Insert(transaction);
    }

    public bool DeleteTransaction(int id)
    {
        return transactionRepository.Delete(id);
    }
}