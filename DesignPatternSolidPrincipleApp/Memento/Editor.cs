namespace Memento;

public class Editor
{
    public string Title { get; set; }
    public string Content { get; set; }

    public override string ToString()
    {
        return $"{Title} - {Content}";
    }

    public void Display()
    {
        Console.WriteLine(ToString());
    }
}
