namespace Memento.Basic;

public class State<T>
{
    private readonly DateTime _createdAt;
    public DateTime CreatedAt { get => _createdAt; }

    private readonly T _historable;
    public T Historable { get => _historable; }

    public State(T editor)
    {
        _historable = editor;
        _createdAt = DateTime.UtcNow;
    }
}
