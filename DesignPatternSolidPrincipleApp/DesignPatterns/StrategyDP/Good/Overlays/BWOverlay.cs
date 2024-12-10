namespace DesignPatterns.StrategyDP.Good.Overlays;

public class BWOverlay : IOverlay
{
    public void Apply(string fileName)
    {
        Console.WriteLine($"overlay {fileName} using BlackAndWhite");
    }
}
