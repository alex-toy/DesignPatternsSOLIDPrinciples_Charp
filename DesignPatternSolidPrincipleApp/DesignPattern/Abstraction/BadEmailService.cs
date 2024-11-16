namespace DesignPattern.Abstraction;

internal class BadEmailService
{
    public void SendEmail()
    {
        Console.WriteLine("send email bad");
    }

    public void Connect()
    {
        Console.WriteLine("connect to the server bad");
    }

    public void Authenticate()
    {
        Console.WriteLine("authenticate bad");
    }

    public void Disconnect()
    {
        Console.WriteLine("disconnect bad");
    }
}
