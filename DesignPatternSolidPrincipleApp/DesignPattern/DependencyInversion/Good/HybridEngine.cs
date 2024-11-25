namespace DesignPattern.DependencyInversion.Good;

internal class HybridEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Hybrid Engine started");
    }
}
