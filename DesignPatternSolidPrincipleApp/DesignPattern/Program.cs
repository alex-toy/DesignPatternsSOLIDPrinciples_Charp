namespace DesignPattern;

internal class Program
{
    static void Main(string[] args)
    {
        BadBankAccount badBankAccount = new () { Balance = 100 };
        badBankAccount.Balance = -50;
        Console.WriteLine(badBankAccount.Balance);

        BankAccount bankAccount = new () { Balance = 100 };
        bankAccount.Balance = -50;
        Console.WriteLine(bankAccount.Balance);
    }
}
