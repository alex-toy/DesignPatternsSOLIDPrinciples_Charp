using DesignPatterns.Commands.Good;

namespace DesignPatterns.Command.Good.Commands;

public class Bright : Command<Light>
{
    public override void Execute()
    {
        Executor.Bright();
    }
}
