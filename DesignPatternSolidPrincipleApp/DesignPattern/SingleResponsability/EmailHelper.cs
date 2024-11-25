namespace DesignPattern.SingleResponsability;

internal class EmailHelper
{
    public void Send(string email, string message)
    {
        Console.WriteLine($"Send email to {email} : {message}");
    }
}
