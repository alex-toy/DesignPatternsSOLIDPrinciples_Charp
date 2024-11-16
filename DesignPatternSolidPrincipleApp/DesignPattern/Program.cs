using DesignPattern.Abstraction;
using DesignPattern.Encapsulation;

namespace DesignPattern;

internal class Program
{
    static void Main(string[] args)
    {
        Abstraction();
        //Encapsulation();
    }

    private static void Abstraction()
    {
        BadEmailService badEmailService = new();
        badEmailService.Connect();
        badEmailService.Authenticate();
        badEmailService.SendEmail();
        badEmailService.Disconnect();

        EmailService emailService = new();
        emailService.SendEmail();
    }

    private static void Encapsulation()
    {
        BadBankAccount badBankAccount = new() { Balance = 100 };
        badBankAccount.Balance = -50;
        Console.WriteLine(badBankAccount.Balance);

        BankAccount bankAccount = new(50);
        //bankAccount.Deposit(-50);
        bankAccount.Deposit(50);
        //bankAccount.Withdraw(-50);
        //bankAccount.Withdraw(150);
        //bankAccount.Withdraw(20);
        Console.WriteLine(bankAccount.Balance);
    }
}
