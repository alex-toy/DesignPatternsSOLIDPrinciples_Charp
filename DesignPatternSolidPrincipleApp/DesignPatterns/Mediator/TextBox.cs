namespace DesignPatterns.Mediator;

public class TextBox : UIControl
{
    private string _text = string.Empty;
    public string Text { get { return _text; } set { _text = value; _owner.Changed(this); } }

    public TextBox(DialogBox dialogBox) : base(dialogBox) { }
}
