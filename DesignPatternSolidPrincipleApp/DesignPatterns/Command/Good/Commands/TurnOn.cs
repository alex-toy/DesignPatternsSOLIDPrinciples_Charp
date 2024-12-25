using DesignPatterns.Commands.Good;

namespace DesignPatterns.Command.Good.Commands;

public class TurnOn : Command<Light>
{
    public override void Execute()
    {
        Executor.TurnOn();
    }
}
