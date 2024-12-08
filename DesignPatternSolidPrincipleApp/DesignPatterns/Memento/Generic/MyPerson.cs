namespace DesignPatterns.Memento.Generic;

public class MyPerson : Item
{
    public string Name { get; set; }

    public override State<MyPerson> CreateState<MyPerson>()
    {
        MyPerson? temp = this as MyPerson;
        return new State<MyPerson>(temp!);
    }

    public override void Restore<MyPerson>(State<MyPerson> state)
    {
        MyPerson? temp = (MyPerson)state.Editor;
        //Name = temp?.Name;
    }

    public void Display()
    {
        Console.WriteLine(Name);
    }
}
