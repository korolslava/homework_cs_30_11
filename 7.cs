public class QueueLike<T>
{
    private List<T> items = new List<T>();
    public void Enqueue(T item)
    {
        items.Add(item);
    }
    public T Dequeue()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        T item = items[0];
        items.RemoveAt(0);
        return item;
    }
    public int Count()
    {
        return items.Count;
    }
    public void PrintAll()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}

class Program {
    static void Main(string[] args)
    {
        QueueLike<int> intQueue = new QueueLike<int>();
        intQueue.Enqueue(1);
        intQueue.Enqueue(2);
        intQueue.Enqueue(3);
        Console.WriteLine("Integer Queue:");
        intQueue.PrintAll();
        Console.WriteLine($"Dequeued: {intQueue.Dequeue()}");
        Console.WriteLine("After Dequeue:");
        intQueue.PrintAll();
        QueueLike<string> stringQueue = new QueueLike<string>();
        stringQueue.Enqueue("Hello");
        stringQueue.Enqueue("World");
        Console.WriteLine("\nString Queue:");
        stringQueue.PrintAll();
        Console.WriteLine($"Dequeued: {stringQueue.Dequeue()}");
        Console.WriteLine("After Dequeue:");
        stringQueue.PrintAll();
    }
}