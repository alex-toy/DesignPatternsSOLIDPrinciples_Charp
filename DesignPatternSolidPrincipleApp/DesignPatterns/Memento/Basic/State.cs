namespace DesignPatterns.Memento.Basic;

public class State
{
    private readonly DateTime _createdAt;
    public DateTime CreatedAt { get => _createdAt; }

    private readonly Editor _editor;
    public Editor Editor { get => _editor; }

    public State(Editor editor)
    {
        _editor = editor;
        _createdAt = DateTime.UtcNow;
    }
}
