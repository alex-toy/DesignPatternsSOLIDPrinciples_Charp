
namespace DesignPatterns.Iterators.Good;

public interface IIterator<T>
{
    void Next();
    T Current();
    bool HasNext();
    void Push(T item);
    T Pop();
    List<T> GetList();
    void Display();
}
