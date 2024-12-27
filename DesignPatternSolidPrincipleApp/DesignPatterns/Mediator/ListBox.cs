namespace DesignPatterns.Mediator;

public class ListBox : UIControl
{
    private string _selection = string.Empty;
    public string Selection { get { return _selection; } set { _selection = value; _owner.Changed(this); } }

    public ListBox(DialogBox dialogBox) : base(dialogBox) { }
}
