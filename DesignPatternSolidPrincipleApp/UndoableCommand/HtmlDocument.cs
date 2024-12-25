namespace UndoableCommand;

public class HtmlDocument
{
    public string Content { get; set; }

    public void MakeItalic()
    {
        Content = $"<i>{Content}</i>";
    }

    public void MakeBold()
    {
        Content = $"<bold>{Content}</bold>";
    }

    public void MakeH1()
    {
        Content = $"<h1>{Content}</h1>";
    }

    public void Display()
    {
        Console.WriteLine(Content);
    }
}
