namespace DesignPatterns.StateDP.Bad;

public class BadBook
{
    public BadState State { get; set; }
    public BadUserRole Role { get; set; }

    public void Publish()
    {
        State = (State, Role) switch
        {
            (BadState.Draft, _) => BadState.Moderation,
            (BadState.Moderation, BadUserRole.Admin) => BadState.Published,
            _ => State,
        };
    }
}
