namespace DesignPatterns.Memento.Basic;

public class Editor
{
    public string Title { get; set; }
    public string Content { get; set; }

    public State CreateState()
    {
        return new State(new Editor() { Content = Content, Title = Title });
    }

    public void Restore(State state)
    {
        Title = state.Editor.Title;
        Content = state.Editor.Content;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}";
    }

    public void Display()
    {
        Console.WriteLine(ToString());
    }
}
