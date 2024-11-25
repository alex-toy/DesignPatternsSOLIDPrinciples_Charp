namespace DesignPattern.DependencyInversion.Good;

internal class Elec_Engine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Electrical Engine started");
    }
}
