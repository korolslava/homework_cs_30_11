using homework_cs_30_11.interfaces;
namespace homework_cs_30_11.classes;

public class Student : IHasId
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}";
    }
}
