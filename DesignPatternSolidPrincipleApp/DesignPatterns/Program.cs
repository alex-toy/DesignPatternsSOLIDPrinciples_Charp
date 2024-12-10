using DesignPatterns.Iterators.Bad;
using DesignPatterns.Iterators.Good;
using DesignPatterns.Memento.Basic;
using DesignPatterns.Memento.Generic;
using DesignPatterns.StateDP.Bad;
using DesignPatterns.StateDP.Good;
using DesignPatterns.StrategyDP.Bad;
using DesignPatterns.StrategyDP.Good;
using DesignPatterns.StrategyDP.Good.Compressors;
using DesignPatterns.StrategyDP.Good.Overlays;

namespace DesignPatterns;

internal class Program
{
    static void Main(string[] args)
    {
        Command();
        //Iterator();
        //Strategy();
        //State();
        //Memento();
    }

    public static void Command()
    {

    }

    public static void Iterator()
    {
        BadShoppingList list = new();
        list.Push("pasta");
        list.Push("vegetables");
        list.Push("dishes");
        list.Display();
        list.Pop();
        list.Display();

        ShoppingList list2 = new();
        list2.Push("fruits");
        list2.Push("cleaning products");
        list2.Push("chewing gum");
        list2.Display();
        list2.Pop();
        list2.Display();
        while (list2.Iterator.HasNext())
        {
            Console.WriteLine(list2.Iterator.Current());
            list2.Iterator.Next();
        }
    }

    public static void Strategy()
    {
        BadVideoStorage storage = new() { Compressor = BadCompressor.MP4, Overlay = BadOverlay.BlackAndWhite };
        storage.Store("my_file.txt");
        storage = new() { Compressor = BadCompressor.MOV, Overlay = BadOverlay.Blur };
        storage.Store("my_file.txt");

        VideoStorage storage2 = new() { Compressor = new MP4Compressor(), Overlay = new BWOverlay() };
        storage2.Store("my_file2.txt");
        storage2 = new() { Compressor = new MOVCompressor(), Overlay = new BlurOverlay() };
        storage2.Store("my_file2.txt");
    }

    public static void State()
    {
        BadBook document = new() { State = BadState.Moderation, Role = BadUserRole.Admin };
        document.Publish();
        Console.WriteLine(document.State);

        Book book = new Book() { Role = UserRole.Admin };
        book.Publish();
        Console.WriteLine(book.State);
        book.Publish();
        Console.WriteLine(book.State);
        book.Publish();
        Console.WriteLine(book.State);
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
