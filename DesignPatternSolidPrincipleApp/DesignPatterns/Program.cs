using DesignPatterns.Memento.Basic;
using DesignPatterns.Memento.Generic;
using DesignPatterns.State;
using DesignPatterns.State.Bad;

namespace DesignPatterns;

internal class Program
{
    static void Main(string[] args)
    {
        State();
        //Memento();
    }

    public static void State()
    {
        Book document = new() { State = DesignPatterns.State.State.Moderation, Role = UserRole.Admin };
        document.Publish();
        Console.WriteLine(document.State);

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

        MyPerson person = new () { Name = "alex" };
        History<MyPerson> history2 = new (person);
        history2.Backup();
        person.Display();
    }
}
