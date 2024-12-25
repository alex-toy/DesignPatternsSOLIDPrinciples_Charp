namespace Memento;

public class Person
{
    public string Name { get; set; }
    public int Salary { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Salary}";
    }

    public void Display()
    {
        Console.WriteLine(ToString());
    }
}
