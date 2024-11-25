using DesignPatterns.Memento.Basic;

namespace DesignPatterns;

internal class Program
{
    static void Main(string[] args)
    {
        Memento();
    }

    public static void Memento()
    {
        Editor editor = new Editor() { Title = "title 1", Content = "content 1" };
        History history = new History(editor);
        history.Backup();
        editor.Display();

        editor.Title = "title 2";
        editor.Content = "content 2";
        history.Backup();
        editor.Display();

        editor.Title = "title 3";
        editor.Content = "content 3";
        history.Backup();
        editor.Display();

        history.Undo();
        editor.Display();

        history.Undo();
        editor.Display();

        history.Undo();
        editor.Display();
    }
}
