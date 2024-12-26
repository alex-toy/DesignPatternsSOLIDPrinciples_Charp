namespace Template;

public abstract class Operation
{
    public void Execute()
    {
        Step1();
        Step2();
        Step3();
        Step4();
    }

    public virtual void Step1()
    {
        Console.WriteLine($"{nameof(Operation)} - {nameof(Step1)}");
    }

    public void Step2()
    {
        Console.WriteLine($"{nameof(Operation)} - {nameof(Step2)}");
    }

    public abstract void Step3();

    public void Step4()
    {
        Console.WriteLine($"{nameof(Operation)} - {nameof(Step4)}");
    }
}
