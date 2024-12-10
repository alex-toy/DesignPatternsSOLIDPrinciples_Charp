namespace DesignPatterns.StateDP.Good.States;

public class Published : State<Book>
{
    public override void Publish()
    {
        Next.State = new Retired() { Next = Next };
    }
}
