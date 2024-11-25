namespace DesignPattern.Coupling.HighCoupling;

internal class BadOrder
{
    public void PlaceOrder()
    {
        BadEmailSender sender = new();
        sender.Send("bad order has been placed");
    }
}
