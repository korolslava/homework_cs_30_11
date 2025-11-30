using homework_cs_30_11.classes;
using homework_cs_30_11.models;

class Program
{
    static void Main(string[] args)
    {
        Group<Member> group1 = new Group<Member>("Group 1");
        Group<Member> group2 = new Group<Member>("Group 2");
        Member member1 = new Member("Alice", 25);
        Member member2 = new Member("Bob", 30);
        Member member3 = new Member("Charlie", 35);
        group1.AddMember(member1);
        group1.AddMember(member2);
        group2.AddMember(member3);
        Console.WriteLine("Members of Group 1:");
        group1.GetMembers();
        Console.WriteLine("Members of Group 2:");
        group2.GetMembers();
        group1.PrintInfo();
        group2.PrintInfo();
        group1.Merge(group2);
        Console.WriteLine("Members of Group 1 after merging with Group 2:");
        group1.GetMembers();
    }
}