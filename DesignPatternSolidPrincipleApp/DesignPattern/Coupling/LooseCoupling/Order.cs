namespace DesignPattern.Coupling.LooseCoupling;

public delegate void Sender(string message);

internal class Order
{
    public Sender Notify;

    public void PlaceOrder()
    {
        EmailSender sender = new();
        if (Notify != null) Notify("order has been placed");
    }
}
