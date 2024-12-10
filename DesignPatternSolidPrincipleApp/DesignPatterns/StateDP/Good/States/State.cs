namespace DesignPatterns.StateDP.Good.States;

public abstract class State<T>
{
    public T Next { get; set; }

    abstract public void Publish();
}
