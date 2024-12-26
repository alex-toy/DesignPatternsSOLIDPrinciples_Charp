namespace ObserverDP.Structure;

public class Publisher
{
    public List<Observer> Observers { get; set; }

    private List<int> _values = new List<int>();
    public List<int> Values
    {
        get { return _values; }
        set
        {
            _values = value;
            NotifyObservers();
        }
    }

    public void NotifyObservers()
    {
        foreach (var observer in Observers) observer.Update();
    }
}
