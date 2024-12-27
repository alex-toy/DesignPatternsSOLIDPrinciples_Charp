namespace DesignPatterns.Mediator;

public class UIControl
{
    protected DialogBox _owner;
    public DialogBox Dialog { get { return _owner; } set { _owner = value; } }

    public UIControl(DialogBox owner)
    {
        _owner = owner;
    }
}