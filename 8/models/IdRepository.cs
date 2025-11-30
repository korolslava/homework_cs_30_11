using homework_cs_30_11.interfaces;
namespace homework_cs_30_11.models;

public class IdRepository<T> where T : IHasId
{
    private List<T> _items = new();
    public void Add(T item)
    {
        _items.Add(item);
    }
    public T? GetById(int id)
    {
        return _items.FirstOrDefault(item => item.Id == id);
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