namespace DesignPatterns.StateDP.Good.States;

public class Moderation : State<Book>
{
    public override void Publish()
    {
        if (Next.Role == UserRole.Admin) Next.State = new Published() { Next = Next };
    }
}
