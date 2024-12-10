namespace DesignPatterns.StrategyDP.Good.Overlays;

public class BlurOverlay : IOverlay
{
    public void Apply(string fileName)
    {
        Console.WriteLine($"overlay {fileName} using Blur");
    }
}
