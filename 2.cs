public class ItemList<T>
{
    List<T> items = new List<T>();
    public void AddItem(T item)
    {
        items.Add(item);
    }
    public void GetAll(out List<T> list) 
    { 
        list = new List<T>(); 
    }
    public void PrintAll()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ItemList<string> stringList = new ItemList<string>();
        stringList.AddItem("Hello");
        stringList.AddItem("World");
        stringList.PrintAll();
        ItemList<int> intList = new ItemList<int>();
        intList.AddItem(1);
        intList.AddItem(2);
        intList.PrintAll();
    }
}