namespace homework_cs_30_11.interfaces;

public interface IRepository<T>
{
    void Add(T entity);
    List<T> GetAll();
}