using UndoableCommand.BaseCommands;

namespace UndoableCommand.Commands;

public class MakeBold : Command<HtmlDocument>
{
    public override void Execute()
    {
        Executor.MakeBold();
        History.Backup();
    }

    public override void UnExecute()
    {
        History.Undo();
    }
}
