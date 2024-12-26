using ObserverDP.Structure;

namespace ObserverDP.Obervers;

public class Sheet : Observer
{
    public override void Update()
    {
        Console.WriteLine($"Sheet - Sum : {Publisher.Values.Sum()}");
    }
}
