namespace DesignPatterns.Iterators.Bad;

public class BadShoppingList
{
    private List<string> _list = new List<string>();

    public void Push(string item)
    {
        _list.Add(item);
    }

    public string Pop()
    {
        var last = _list.Last();
        _list.Remove(last);
        return last;
    }

    public List<string> GetList()
    {
        return _list;
    }

    public void Display()
    {
        string list = "";
        foreach (var item in _list) list += ", " + item;
        Console.WriteLine(list);
    }
}
