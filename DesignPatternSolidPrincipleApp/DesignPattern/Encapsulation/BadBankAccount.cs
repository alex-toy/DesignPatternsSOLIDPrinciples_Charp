namespace DesignPattern.Encapsulation;

public class BadBankAccount
{
    public decimal Balance { get; set; }

    public void Deposit(decimal amount)
    {
        if (amount <= 0) throw new ArgumentException("amount should be greater than zero");
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0) throw new ArgumentException("amount should be greater than zero");
        if (amount > Balance) throw new ArgumentException("insufficient funds");
        Balance -= amount;
    }
}
