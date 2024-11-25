namespace DesignPattern.Polymorphism;

internal class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("car starting");
    }

    public override void Stop()
    {
        Console.WriteLine("car stopping");
    }
}
