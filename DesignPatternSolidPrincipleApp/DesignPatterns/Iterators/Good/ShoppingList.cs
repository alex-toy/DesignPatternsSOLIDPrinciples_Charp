namespace DesignPatterns.Iterators.Good;

public class ShoppingList
{
    public string[] Articles = new string[5];
    public ArrayIterator<string> Iterator { get; private set; }

    //public List<string> Articles = new List<string>();
    //public ListIterator<string> Iterator { get; private set; }

    public ShoppingList()
    {
        Iterator = new ArrayIterator<string>() { Items = Articles };
        //Iterator = new ListIterator<string>() { Items = Articles };
    }

    public void Push(string item)
    {
        Iterator.Push(item);
    }

    public string Pop()
    {
        return Iterator.Pop();
    }

    public List<string> GetList()
    {
        return Iterator.GetList();
    }

    public void Display()
    {
        Iterator.Display();
    }
}
