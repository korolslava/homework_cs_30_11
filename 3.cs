public class History<T>
{
    private List<T> _items = new List<T>();
    private int _maxCount;
    public History(int maxCount)
    {
        _maxCount = maxCount;
    }
    public void Add(T item)
    {
        if (_items.Count >= _maxCount)
        {
            _items.RemoveAt(0);
        }
        _items.Add(item);
    }
    public List<T> GetAll()
    {
        return new List<T>(_items);
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
        History<string> history = new History<string>(5);
        history.Add("First");
        history.Add("Second");
        history.Add("Third");
        history.Add("Fourth");
        history.Add("Fifth");
        history.Add("Sixth");
        history.PrintAll();
    }
}