using GastosResidenciais.WebApi.API.DTOs;
using GastosResidenciais.WebApi.API.Interfaces;
using GastosResidenciais.WebApi.Application.Interfaces;
using GastosResidenciais.WebApi.Domain.Entities;

namespace GastosResidenciais.WebApi.Application.Services;

public class CategoryService(ICategoryRepository categoryRepository) : ICategoryService
{
    public IEnumerable<Category> ListCategories()
    {
        return categoryRepository.GetMany();
    }

    public Category GetCategory(int id)
    {
        return categoryRepository.GetOne(id);
    }

    public Category InsertCategory(CategoryDto dto)
    {
        var category = new Category { Description = dto.Description, Purpose = dto.Purpose };
        return categoryRepository.Insert(category);
    }

    public bool DeleteCategory(int id)
    {
        return categoryRepository.Delete(id);
    }
}