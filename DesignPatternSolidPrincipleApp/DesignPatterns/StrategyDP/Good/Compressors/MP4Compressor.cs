namespace DesignPatterns.StrategyDP.Good.Compressors;

public class MP4Compressor : ICompressor
{
    public void Compress(string fileName)
    {
        Console.WriteLine($"compress {fileName} using MP4");
    }
}
