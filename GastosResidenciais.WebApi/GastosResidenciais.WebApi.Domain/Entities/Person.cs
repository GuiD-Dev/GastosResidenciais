using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GastosResidenciais.WebApi.Domain.Entities;

[Table("person")]
public class Person
{
    [Column("id"), Key]
    public int Id { get; set; }
    
    [Column("name"), Required]
    public string Name { get; set; }
    
    [Column("age"), Required]
    public uint Age { get; set; }

    public Person(string name, uint age)
    {
        Name = name;
        Age = age;
    }
}
