using DesignPatterns.StrategyDP.Bad;
using DesignPatterns.StrategyDP.Good.Compressors;
using DesignPatterns.StrategyDP.Good.Overlays;

namespace DesignPatterns.StrategyDP.Good;

public class VideoStorage
{
    public ICompressor Compressor {  private get; set; }
    public IOverlay? Overlay {  private get; set; }

    public void Store(string fileName)
    {
        Compressor.Compress(fileName);
        if (Overlay is not null) Overlay.Apply(fileName);
        else Console.WriteLine($"overlay {fileName} using None");
    }
}
