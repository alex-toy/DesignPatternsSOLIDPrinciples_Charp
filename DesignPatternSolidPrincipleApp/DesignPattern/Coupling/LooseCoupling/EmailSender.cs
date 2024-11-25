namespace DesignPattern.Coupling.LooseCoupling;

internal class EmailSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending mail : {message}");
    }
}
