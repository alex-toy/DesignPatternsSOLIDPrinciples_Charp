namespace DesignPatterns.Iterators.Good;

public class ArrayIterator<T> : IIterator<T>
{
    private int _index = 0;
    private int _filling = 0;
    public T[] Items { get; set; }

    public T Current()
    {
        return Items[_index];
    }

    public void Display()
    {
        string list = "";
        int index = 0;
        foreach (var item in Items)
        {
            if (index > _filling) break;
            list += ", " + item;
            index++;
        }
            
        Console.WriteLine(list);
    }

    public List<T> GetList()
    {
        return Items.ToList();
    }

    public bool HasNext()
    {
        return _index < Items.Count() && _index < _filling;
    }

    public void Next()
    {
        if (_index > _filling) return;
        _index++;
    }

    public T Pop()
    {
        _index--;
        _filling--;
        return Items[_filling];
    }

    public void Push(T item)
    {
        _index++;
        _filling++;
        if (_index < Items.Count()) Items[_index] = item;
    }
}
