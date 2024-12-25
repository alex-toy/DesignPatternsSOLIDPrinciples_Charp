using DesignPatterns.Commands.Good;

namespace DesignPatterns.Command.Good.Commands;

public class TurnOff : Command<Light>
{
    public override void Execute()
    {
        Executor.TurnOff();
    }
}
