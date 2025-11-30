namespace homework_cs_30_11.models;

public class Group<TMember> where TMember : class
{
    public string Name { get; set; }
    List<TMember> members;
    public Group(string name)
    {
        Name = name;
        members = new List<TMember>();
    }
    public void AddMember(TMember member)
    {
        members.Add(member);
    }
    public void GetMembers()
    {
        foreach (var member in members)
        {
            Console.WriteLine(member);
        }
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Group: {Name}, Members list - {string.Join(", ", members)}");
    }
    public void Merge(Group<TMember> other)
    {
        members.AddRange(other.members);
    }
}