namespace DesignPatterns.Memento.Generic;

public class History<T> where T : Item, new()
{
    private List<State<T>> _history = new List<State<T>>();
    private T _item;

    public History(T item)
    {
        _item = item;
    }

    public void Backup()
    {
        _history.Add(_item.CreateState<T>());
    }

    public void Undo()
    {
        if (_history.Count == 0) return;
        _history.RemoveAt(_history.Count - 1);
        if (_history.Count == 0) return;
        State<T> prevState = _history.Last();
        _item.Restore<T>(prevState);
    }
}
