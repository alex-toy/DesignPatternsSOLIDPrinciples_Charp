namespace DesignPatterns.Memento.Basic;

public class History
{
    private List<State> _history = new List<State>();
    private Editor _editor;

    public History(Editor editor)
    {
        _editor = editor;
    }

    public State CreateState(Editor editor)
    {
        return new State(new Editor() { Content = editor.Content, Title = editor.Title });
    }

    public void Restore(State state)
    {
        _editor.Title = state.Editor.Title;
        _editor.Content = state.Editor.Content;
    }

    public void Backup()
    {
        _history.Add(CreateState(_editor));
    }

    public void Undo()
    {
        if (_history.Count == 0) return;
        _history.RemoveAt(_history.Count - 1);
        if (_history.Count == 0) return;
        State prevState = _history.Last();
        Restore(prevState);
    }

    public void ShowHistrory()
    {
        foreach (var state in _history) Console.WriteLine($"{state.CreatedAt} - {state.Editor.Title} - {state.Editor.Content}");
    }
}
