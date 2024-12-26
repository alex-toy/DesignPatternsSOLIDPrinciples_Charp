namespace Template;

public class OperationA : Operation
{
    public override void Step1()
    {
        Console.WriteLine($"{nameof(OperationA)} - {nameof(Step1)}");
    }

    public override void Step3()
    {
        Console.WriteLine($"{nameof(OperationA)} - {nameof(Step3)}");
    }
}
