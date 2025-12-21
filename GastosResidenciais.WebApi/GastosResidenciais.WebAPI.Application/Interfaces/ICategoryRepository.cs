using GastosResidenciais.WebApi.Domain.Entities;

namespace GastosResidenciais.WebApi.Application.Interfaces;

public interface ICategoryRepository
{
    IEnumerable<Category> GetMany();
    Category GetOneById(int id);
    Category Insert(Category category);
    bool Delete(int id);
}