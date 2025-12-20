namespace GastosResidenciais.WebApi.Domain.Entities;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public uint Age { get; set; }

    public Person(string name, uint age)
    {
        Name = name;
        Age = age;
    }
}
