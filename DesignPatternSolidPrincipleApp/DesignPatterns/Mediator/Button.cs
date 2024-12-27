namespace DesignPatterns.Mediator;

public class Button : UIControl
{
    private bool _isEnabled = false;
    public bool IsEnabled { get { return _isEnabled; } set { _isEnabled = value; _owner.Changed(this); } }

    public Button(DialogBox dialogBox) : base(dialogBox) { }
}
