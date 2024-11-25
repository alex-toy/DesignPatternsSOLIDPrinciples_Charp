namespace DesignPattern.SingleResponsability.Bad;

internal class BadUser
{
    public string Name { get; set; }
    public string Email { get; set; }

    public void Register()
    {
        EmailHelper emailSender = new ();
        emailSender.Send(Email, $"Bad Welcome {Name} to our plaform");
    }
}
