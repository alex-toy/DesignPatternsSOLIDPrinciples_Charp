namespace DesignPatterns.Memento.Generic;

public abstract class Item
{
    public abstract State<T> CreateState<T>() where T : class, new();

    public abstract void Restore<T>(State<T> state);
}
