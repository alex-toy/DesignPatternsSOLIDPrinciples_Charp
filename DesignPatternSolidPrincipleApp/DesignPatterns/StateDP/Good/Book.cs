
using DesignPatterns.StateDP.Good.States;

namespace DesignPatterns.StateDP.Good;

public class Book
{
    public State<Book> State { get; set; }
    public UserRole Role { get; set; }

    public void Publish()
    {
        if (State is null) State = new Draft() { Next = this };
        State.Publish();
    }
}
