namespace DesignPattern.SingleResponsability.Good;

internal class UserService
{
    public User User { get; set; }

    public void Register()
    {
        EmailHelper emailSender = new();
        emailSender.Send(User.Email, $"Welcome {User.Name} to our plaform");
    }
}
