using Memento.Structure;
using UndoableCommand.BaseCommands;

namespace UndoableCommand;

public class Printer
{
    public ICommand Command { get; set; }

    public void Print()
    {
        Command.Execute();
    }

    public void UnPrint()
    {
        Command.UnExecute();
    }
}
