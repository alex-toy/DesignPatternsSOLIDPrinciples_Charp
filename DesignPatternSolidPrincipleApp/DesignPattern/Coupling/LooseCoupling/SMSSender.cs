namespace DesignPattern.Coupling.LooseCoupling;

internal class SMSSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending SMS : {message}");
    }
}
