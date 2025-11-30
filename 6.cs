public class UniqueCollection<T>
{
    List<T> _items = new List<T>();
    public void Add(T item)
    {
        if (!_items.Contains(item))
        {
            _items.Add(item);
        }
    }
    public List<T> GetAll()
    {
        return _items;
    }
    public void PrintAll()
    {
        foreach (var item in _items)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        UniqueCollection<string> stringCollection = new UniqueCollection<string>();
        stringCollection.Add("apple");
        stringCollection.Add("banana");
        stringCollection.Add("apple");
        stringCollection.PrintAll();
        UniqueCollection<int> intCollection = new UniqueCollection<int>();
        intCollection.Add(1);
        intCollection.Add(2);
        intCollection.Add(1);
        intCollection.PrintAll();
    }
}