namespace DesignPatterns.StrategyDP.Good.Compressors;

public class WEBMCompressor : ICompressor
{
    public void Compress(string fileName)
    {
        Console.WriteLine($"compress {fileName} using WEBM");
    }

}
