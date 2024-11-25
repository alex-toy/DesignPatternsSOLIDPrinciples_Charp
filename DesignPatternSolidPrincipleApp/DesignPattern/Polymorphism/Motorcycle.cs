namespace DesignPattern.Polymorphism;

internal class Motorcycle : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Motorcycle starting");
    }

    public override void Stop()
    {
        Console.WriteLine("Motorcycle stopping");
    }
}
