namespace DesignPatterns.Mediator;

public class PostsDialogBox : DialogBox
{
    private ListBox _listBox;
    private TextBox _textBox;
    private Button _button;

    public PostsDialogBox()
    {
        _listBox = new ListBox(this);
        _textBox = new TextBox(this);
        _button = new Button(this);
        _button.IsEnabled = false;
    }

    public void SimulateUserInteraction()
    {
        _listBox.Selection = "Post 2";
        Console.WriteLine(_textBox.Text);
        Console.WriteLine(_button.IsEnabled);
    }
    
    public override void Changed(UIControl uIControl)
    {
        if (uIControl == _listBox)
        {
            HandlePostChanged();
        }
        else if (uIControl == _textBox)
        {
            HandleTitleChanged();
        }
    }

    private void HandleTitleChanged()
    {
        _button.IsEnabled = !string.IsNullOrEmpty(_textBox.Text);
    }

    private void HandlePostChanged()
    {
        _textBox.Text = _listBox.Selection;
        _button.IsEnabled = true;
    }
}
