namespace homework_cs_30_11.classes;

public class Student
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
        return $"Student(Id: {Id}, Name: {Name})";
    }
}