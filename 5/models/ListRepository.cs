using homework_cs_30_11.interfaces;
namespace homework_cs_30_11.models;

public class ListRepository<T> : IRepository<T>
{
    List<T> items = new List<T>();
    public void Add(T entity)
    {
        items.Add(entity);
    }
    List<T> IRepository<T>.GetAll()
    {
        return items;
    }
}
