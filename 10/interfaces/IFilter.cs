namespace homework_cs_30_11.interfaces;

public interface IFilter<T> 
{
    bool IsMatch(T value);
}