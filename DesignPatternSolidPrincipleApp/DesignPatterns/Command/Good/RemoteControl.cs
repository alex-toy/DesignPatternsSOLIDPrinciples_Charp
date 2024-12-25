using DesignPatterns.Command.Good.Commands;

namespace DesignPatterns.Commands.Good;

public class RemoteControl
{
    private ICommand _command;
    public ICommand Command { get { return _command; } set { _command = value; } }

    public void PressButton()
    {
        _command.Execute();
    }
}
