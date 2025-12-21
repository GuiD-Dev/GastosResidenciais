using GastosResidenciais.WebApi.Application.Interfaces;
using GastosResidenciais.WebApi.Domain.Entities;
using GastosResidenciais.WebApi.Infra.Contexts;

namespace GastosResidenciais.WebApi.Infra.Repositories;

public class CategoryRepository(PgSqlDbContext context) : ICategoryRepository
{
    public IEnumerable<Category> GetMany()
    {
        return context.Categories.ToList();
    }

    public Category GetOne(int id)
    {
        throw new NotImplementedException();
    }

    public Category Insert(Category category)
    {
        context.Categories.Add(category);
        context.SaveChanges();
        return category;
    }

    public bool Delete(int id)
    {
        var category = context.Categories.FirstOrDefault(p => p.Id == id);
        if (category is null)
            throw new Exception("Id not found");

        context.Categories.Remove(category);
        context.SaveChanges();

        return true;
    }
}
