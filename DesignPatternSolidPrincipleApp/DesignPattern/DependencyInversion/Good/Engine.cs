namespace DesignPattern.DependencyInversion.Good;

internal class Engine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Engine started");
    }
}
