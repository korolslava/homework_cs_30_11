public class ValueContainer<T>
{
    public T Value { get; set; }
    public void PrintValue()
    {
        System.Console.WriteLine(Value);
    }
}

class Program
{
    static void Main()
    {
        var intContainer = new ValueContainer<int> { Value = 42 };
        intContainer.PrintValue();
        var stringContainer = new ValueContainer<string> { Value = "Hello, World!" };
        stringContainer.PrintValue();
    }
}