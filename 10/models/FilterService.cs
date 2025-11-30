using homework_cs_30_11.interfaces;
namespace homework_cs_30_11.models;

public class FilterService<T>
{
    List<T> _items = new List<T>();
    public FilterService(List<T> items)
    {
        _items = items;
    }
    public void Filter(IFilter<T> filter)
    {
        var filteredItems = new List<T>();
        foreach (var item in _items)
        {
            if (filter.IsMatch(item))
            {
                filteredItems.Add(item);
            }
        }
        _items = filteredItems;
    }

}