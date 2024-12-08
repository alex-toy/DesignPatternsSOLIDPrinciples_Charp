namespace DesignPatterns.State.Bad;

public class Book
{
    public State State { get; set; }
    public UserRole Role { get; set; }

    public void Publish()
    {
        State = (State, Role) switch
        {
            (State.Draft, _) => State.Moderation,
            (State.Moderation, UserRole.Admin) => State.Published,
            _ => State,
        };
    }
}
