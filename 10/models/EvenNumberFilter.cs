using homework_cs_30_11.interfaces;

namespace homework_cs_30_11.models;

public class EvenNumberFilter : IFilter<int>
{
    public bool IsMatch(int value)
    {
        return value % 2 == 0;
    }
}
