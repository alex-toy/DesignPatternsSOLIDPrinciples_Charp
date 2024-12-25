using Memento.Structure;

namespace Memento;

internal class Program
{
    static void Main(string[] args)
    {
        Memento2();
    }

    public static void Memento()
    {
        Editor editor = new Editor() { Title = "title 1", Content = "content 1" };
        History<Editor> history = new(editor);
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

        editor.Title = "title 4";
        editor.Content = "content 4";
        history.Backup();
        editor.Display();

        history.Undo();
        editor.Display();

        history.Undo();
        editor.Display();

        history.Undo();
        editor.Display();

        history.Undo();
        editor.Display();
    }

    public static void Memento2()
    {
        Person person = new () { Name = "alex", Salary = 2000 };
        History<Person> history = new(person);
        history.Backup();
        person.Display();

        person.Salary = 3000;
        history.Backup();
        person.Display();

        person.Salary = 4000;
        history.Backup();
        person.Display();

        person.Salary = 5000;
        history.Backup();
        person.Display();

        history.Undo();
        person.Display();

        history.Undo();
        person.Display();

        history.Undo();
        person.Display();

        history.Undo();
        person.Display();
    }
}
