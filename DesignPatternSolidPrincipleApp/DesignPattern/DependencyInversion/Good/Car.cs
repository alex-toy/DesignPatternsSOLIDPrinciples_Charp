namespace DesignPattern.DependencyInversion.Good;

internal class Car
{
    private IEngine _engine;

    public Car(IEngine engine)
    {
        _engine = engine;
    }

    public void Start()
    {
        _engine.Start();
        Console.WriteLine("Car started");
    }
}
