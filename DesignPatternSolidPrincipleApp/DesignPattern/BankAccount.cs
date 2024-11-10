namespace DesignPattern;

public class BankAccount
{
    private decimal _balance;
    public decimal Balance
    {
        get { return _balance; }
        set { Deposit(value); }
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0) throw new ArgumentException("amount should be greater than zero");
        _balance += amount;
    }
}
