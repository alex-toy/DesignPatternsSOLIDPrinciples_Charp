namespace DesignPatterns.StrategyDP.Bad;

public class BadVideoStorage
{
    public BadCompressor Compressor { private get; set; }
    public BadOverlay Overlay { private get; set; }

    public void Store(string fileName)
    {
        if (Compressor == BadCompressor.MOV) Console.WriteLine($"compress {fileName} using MOV");
        if (Compressor == BadCompressor.WEBM) Console.WriteLine($"compress {fileName} using WEBM");
        if (Compressor == BadCompressor.MP4) Console.WriteLine($"compress {fileName} using MP4");

        if (Overlay == BadOverlay.None) Console.WriteLine($"overlay {fileName} using None");
        if (Overlay == BadOverlay.Blur) Console.WriteLine($"overlay {fileName} using Blur");
        if (Overlay == BadOverlay.BlackAndWhite) Console.WriteLine($"overlay {fileName} using BlackAndWhite");
    }
}
