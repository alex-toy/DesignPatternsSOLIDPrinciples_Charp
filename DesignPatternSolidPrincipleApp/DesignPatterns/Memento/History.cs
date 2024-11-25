namespace DesignPatterns.Memento;

public class History
{
    private List<State> _history = new List<State>();
    private Editor _editor;

    public History(Editor editor)
    {
        _editor = editor;
    }

    public void Backup()
    {
        _history.Add(_editor.CreateState());
    }

    public void Undo()
    {
        if (_history.Count == 0) return;
        State prevState = _history.Last();
        _history.RemoveAt(_history.Count - 1);
        _editor.Restore(prevState);
    }

    public void ShowHistrory()
    {
        foreach (var state in _history) Console.WriteLine($"{state.CreatedAt} - {state.Editor.Title} - {state.Editor.Content}");
    }
}
