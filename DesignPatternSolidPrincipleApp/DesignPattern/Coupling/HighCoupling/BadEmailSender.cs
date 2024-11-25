namespace DesignPattern.Coupling.HighCoupling;

internal class BadEmailSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending bad mail : {message}");
    }
}
