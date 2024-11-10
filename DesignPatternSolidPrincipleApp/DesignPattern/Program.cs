namespace DesignPattern;

internal class Program
{
    static void Main(string[] args)
    {
        BadBankAccount badBankAccount = new() { Balance = 100 };
        badBankAccount.Balance = -50;
        Console.WriteLine(badBankAccount.Balance);

        BankAccount bankAccount = new (50);
        //bankAccount.Deposit(-50);
        bankAccount.Deposit(50);
        //bankAccount.Withdraw(-50);
        //bankAccount.Withdraw(150);
        //bankAccount.Withdraw(20);
        Console.WriteLine(bankAccount.Balance);
    }
}
