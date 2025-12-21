using GastosResidenciais.WebApi.Domain.Entities;
using GastosResidenciais.WebApi.Domain.Enums;

namespace GastosResidenciais.WebApi.API.DTOs;

public class TransactionDto
{
    public string Description { get; set; }
    public decimal Value { get; set; }
    public TransactionType Type { get; set; }
    public int CategoryId { get; set; }
    public int PersonId { get; set; }
}