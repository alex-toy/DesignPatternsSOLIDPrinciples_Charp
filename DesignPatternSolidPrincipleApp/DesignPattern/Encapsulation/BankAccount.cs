namespace DesignPattern.Encapsulation;

public class BankAccount
{
    private decimal _balance = 0;
    public decimal Balance
    {
        get { return _balance; }
    }

    public BankAccount(PositiveDecimal initialAmount)
    {
        Deposit(initialAmount);
    }

    public void Deposit(PositiveDecimal amount)
    {
        _balance += (decimal)amount;
    }

    public void Withdraw(PositiveDecimal amount)
    {
        if (amount > _balance) throw new ArgumentException("insufficient funds");
        _balance -= (decimal)amount;
    }
}
