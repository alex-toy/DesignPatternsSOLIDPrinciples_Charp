namespace DesignPatterns.StateDP.Good.States;

public class Draft : State<Book>
{
    public override void Publish()
    {
        Next.State = new Moderation() { Next = Next};
    }
}
