namespace Template;

public class OperationB : Operation
{
    public override void Step3()
    {
        Console.WriteLine($"{nameof(OperationB)} - {nameof(Step3)}");
    }
}
