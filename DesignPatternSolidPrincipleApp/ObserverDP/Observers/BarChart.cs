using ObserverDP.Structure;

namespace ObserverDP.Obervers;

public class BarChart : Observer
{
    public override void Update()
    {
        string chart = Publisher.Values.Aggregate("", (v, acc) => $"{acc} {v}");
        Console.WriteLine($"BarChart - {chart}");
    }
}
