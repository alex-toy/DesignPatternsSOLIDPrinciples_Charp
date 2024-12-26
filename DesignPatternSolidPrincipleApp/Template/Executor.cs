namespace Template;

public class Executor
{
    public Operation Operation { get; set; }

    public void Execute()
    {
        Operation.Execute();
    }
}
