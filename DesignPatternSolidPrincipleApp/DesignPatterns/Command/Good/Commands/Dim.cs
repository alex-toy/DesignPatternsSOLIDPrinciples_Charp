using DesignPatterns.Commands.Good;

namespace DesignPatterns.Command.Good.Commands;

public class Dim : Command<Light>
{
    public override void Execute()
    {
        Executor.Dim();
    }
}
