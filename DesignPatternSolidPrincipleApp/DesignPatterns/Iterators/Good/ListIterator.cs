namespace DesignPatterns.Iterators.Good;

public class ListIterator<T> : IIterator<T>
{
    private int _index = 0;
    public List<T> Items { get; set; }

    public T Current()
    {
        return Items[_index];
    }

    public bool HasNext()
    {
        return _index < Items.Count;
    }

    public void Next()
    {
        _index++;
    }

    public void Push(T item)
    {
        Items.Add(item);
    }

    public T Pop()
    {
        var last = Items.Last();
        Items.Remove(last);
        return last;
    }

    public List<T> GetList()
    {
        return Items;
    }

    public void Display()
    {
        string list = "";
        foreach (var item in Items) list += ", " + item;
        Console.WriteLine(list);
    }
}
