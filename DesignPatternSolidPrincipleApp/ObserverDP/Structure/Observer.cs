namespace ObserverDP.Structure;

public abstract class Observer
{
    public Publisher Publisher { get; set; }
    public abstract void Update();
}
