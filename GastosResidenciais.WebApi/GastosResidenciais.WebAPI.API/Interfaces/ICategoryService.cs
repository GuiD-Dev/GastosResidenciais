using GastosResidenciais.WebApi.API.DTOs;
using GastosResidenciais.WebApi.Domain.Entities;

namespace GastosResidenciais.WebApi.API.Interfaces;

public interface ICategoryService
{
    IEnumerable<Category> ListCategories();
    Category GetCategory(int id);
    Category InsertCategory(CategoryDto dto);
    bool DeleteCategory(int id);
}