namespace Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Executor executor = new Executor() { Operation = new OperationA() };
            executor.Execute();

            executor.Operation = new OperationB();
            executor.Execute();
        }
    }
}
