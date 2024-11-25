namespace DesignPattern.Polymorphism;

internal class Vehicle
{
    public string Brand { get; set; } 
    public int Year { get; set; }

    public virtual void Start()
    {
        Console.WriteLine("vehicle starting");
    }

    public virtual void Stop()
    {
        Console.WriteLine("vehicle stopping");
    }
}
