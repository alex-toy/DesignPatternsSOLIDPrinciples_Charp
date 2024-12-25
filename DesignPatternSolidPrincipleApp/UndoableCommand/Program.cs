using Memento.Structure;
using UndoableCommand.Commands;

namespace UndoableCommand;

internal class Program
{
    static void Main(string[] args)
    {
        UndoableCommand();
    }

    public static void UndoableCommand()
    {
        HtmlDocument htmlDocument = new() { Content = "content 1" };
        History<HtmlDocument> history = new(htmlDocument);
        Printer printer = new ();
        history.Backup();
        htmlDocument.Display();

        htmlDocument.Content = "content 2";
        printer.Command = new MakeItalic() { Executor = htmlDocument, History = history };
        printer.Print();
        htmlDocument.Display();

        htmlDocument.Content = "content 3";
        printer.Command = new MakeBold() { Executor = htmlDocument, History = history };
        printer.Print();
        htmlDocument.Display();

        printer.UnPrint();
        htmlDocument.Display();

        printer.UnPrint();
        htmlDocument.Display();

        htmlDocument.Content = "content 4";
        printer.Command = new MakeH1() { Executor = htmlDocument, History = history };
        printer.Print();
        htmlDocument.Display();

        printer.UnPrint();
        htmlDocument.Display();
    }
}
