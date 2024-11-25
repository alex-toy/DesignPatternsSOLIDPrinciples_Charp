namespace DesignPatterns.Memento.Generic;

public class APerson : Item
{
    public string Name { get; set; }

    public override State<APerson> CreateState<APerson>()
    {
        APerson? temp = this as APerson;
        return new State<APerson>(temp);
    }

    public override void Restore<APerson>(State<APerson> state)
    {
        var temp = state.Editor as APerson;
        Name = temp.Name;
    }
}
