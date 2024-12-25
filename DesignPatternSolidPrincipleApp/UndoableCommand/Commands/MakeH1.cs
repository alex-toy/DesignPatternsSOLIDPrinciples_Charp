using UndoableCommand.BaseCommands;

namespace UndoableCommand.Commands;

public class MakeH1 : Command<HtmlDocument>
{
    public override void Execute()
    {
        Executor.MakeH1();
        History.Backup();
    }

    public override void UnExecute()
    {
        History.Undo();
    }
}
