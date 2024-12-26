namespace DesignPatterns.Template;

public class OperationA
{
    public void Execute()
    {
        Step1();
        Step2();
        Step3();
        Step4();
    }

    public void Step1()
    {
        Console.WriteLine($"{nameof(OperationA)} - {nameof(Step1)}");
    }

    public void Step2()
    {
        Console.WriteLine($"Step 2");
    }

    public void Step3()
    {
        Console.WriteLine($"{nameof(OperationA)} - {nameof(Step3)}");
    }

    public void Step4()
    {
        Console.WriteLine($"Step 4");
    }
}
