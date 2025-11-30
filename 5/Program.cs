using homework_cs_30_11.interfaces;
using homework_cs_30_11.models;
using homework_cs_30_11.classes;

class Program
{
    static void Main(string[] args)
    {
        IRepository<Student> studentRepository = new ListRepository<Student>();
        studentRepository.Add(new Student(1, "Alice"));
        studentRepository.Add(new Student(2, "Bob"));
        List<Student> students = studentRepository.GetAll();
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}