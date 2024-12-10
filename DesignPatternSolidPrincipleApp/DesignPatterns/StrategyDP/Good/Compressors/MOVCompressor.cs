namespace DesignPatterns.StrategyDP.Good.Compressors;

public class MOVCompressor : ICompressor
{
    public void Compress(string fileName)
    {
        Console.WriteLine($"compress {fileName} using MOV");
    }
}
