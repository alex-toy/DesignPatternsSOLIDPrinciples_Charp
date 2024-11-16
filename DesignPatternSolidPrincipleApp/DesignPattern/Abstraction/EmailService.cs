using System;

namespace DesignPattern.Abstraction;

internal class EmailService
{
    public void SendEmail()
    {
        Connect();
        Authenticate();
        Console.WriteLine("send email");
        Log();
        Disconnect();
    }

    private void Connect()
    {
        Console.WriteLine("connect to the server");
    }

    private void Authenticate()
    {
        Console.WriteLine("authenticate");
    }

    private void Disconnect()
    {
        Console.WriteLine("disconnect");
    }

    private void Log()
    {
        Console.WriteLine("logging");
    }
}
