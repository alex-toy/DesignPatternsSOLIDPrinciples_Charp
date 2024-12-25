using UndoableCommand.BaseCommands;

namespace UndoableCommand.Commands;

public class MakeItalic : Command<HtmlDocument>
{
    public override void Execute()
    {
        Executor.MakeItalic();
        History.Backup();
    }

    public override void UnExecute()
    {
        History.Undo();
    }
}
