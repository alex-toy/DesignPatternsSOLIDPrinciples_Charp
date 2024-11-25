namespace DesignPattern.DependencyInversion.Bad;

internal class B_Car
{
    private B_Engine _engine;
    private B_Elec_Engine _elecEngine;
    private B_HybridEngine _hybridEngine;

    public B_Car(B_Elec_Engine elecEngine)
    {
        _elecEngine = elecEngine;
    }

    public B_Car(B_Engine engine)
    {
        _engine = engine;
    }

    public B_Car(B_HybridEngine engine)
    {
        _hybridEngine = engine;
    }

    public void Start()
    {
        if (_engine is not null) _engine.Start();
        if (_elecEngine is not null) _elecEngine.Start();
        if (_hybridEngine is not null) _hybridEngine.Start();
        Console.WriteLine("Car started");
    }
}
