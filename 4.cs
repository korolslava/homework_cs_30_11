public class DoubleCollection<T>
{
    List<T> _first = new List<T>();
    List<T> _second = new List<T>();

    public void AddToFirst(T item) => _first.Add(item);
    public void AddToSecond(T item) => _second.Add(item);

    public void GetFirstItems(Action<T> action)
    {
        foreach (var item in _first)
        {
            action(item);
        }
    }
    public void GetSecondItems(Action<T> action)
    {
        foreach (var item in _second)
        {
            action(item);
        }
    }
    public void PrintBothCollections()
    {
        Console.WriteLine("First Collection:");
        GetFirstItems(item => Console.WriteLine(item));
        Console.WriteLine("Second Collection:");
        GetSecondItems(item => Console.WriteLine(item));
    }
}

class Program
{
    static void Main(string[] args)
    {
        var collection = new DoubleCollection<string>();

        collection.AddToFirst("John");
        collection.AddToFirst("Mary");
        collection.AddToFirst("Peter");

        collection.AddToSecond("Mr. Anderson");
        collection.AddToSecond("Mrs. Thompson");
        collection.AddToSecond("Mr. Williams");

        collection.PrintBothCollections();
    }
}