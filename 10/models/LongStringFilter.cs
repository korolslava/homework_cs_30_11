using homework_cs_30_11.interfaces;

namespace homework_cs_30_11.models;

public class LongStringFilter : IFilter<string>
{
    private int _minLength;

    public LongStringFilter(int minLength)
    {
        _minLength = minLength;
    }

    public bool IsMatch(string value)
    {
        return value?.Length > _minLength;
    }
}