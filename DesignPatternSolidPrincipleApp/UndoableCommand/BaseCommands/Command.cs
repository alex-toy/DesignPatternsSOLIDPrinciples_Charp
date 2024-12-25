using Memento.Structure;

namespace UndoableCommand.BaseCommands;

public abstract class Command<T> : ICommand where T : class
{
    private T _executor;
    public T Executor { get => _executor; set { _executor = value; } }

    public History<T> History { get; set; }

    public abstract void Execute();
    public abstract void UnExecute();
}
