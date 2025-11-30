namespace homework_cs_30_11.classes;

class Member
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Member(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}