using homework_cs_30_11.interfaces;
using homework_cs_30_11.models;
using homework_cs_30_11.classes;

class Program
{
    static void Main(string[] args)
    {
        IdRepository<Student> studentRepository = new IdRepository<Student>();
        studentRepository.Add(new Student(1, "Alice"));
        studentRepository.Add(new Student(2, "Bob"));
        studentRepository.Add(new Student(3, "Charlie"));
        Student? student = studentRepository.GetById(2);
        studentRepository.PrintAll();
    }
}