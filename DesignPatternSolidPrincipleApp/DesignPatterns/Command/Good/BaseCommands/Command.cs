namespace DesignPatterns.Command.Good.Commands;

public abstract class Command<T> : ICommand where T : class
{
    private T _executor;
    public T Executor { get => _executor; set { _executor = value; } }

    public abstract void Execute();
}
