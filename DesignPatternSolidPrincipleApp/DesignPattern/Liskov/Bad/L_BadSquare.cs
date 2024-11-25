namespace DesignPattern.Liskov.Bad;

internal class L_BadSquare : L_BadRectangle
{
    public override double Width { get => base.Length; }
    public override double Length { get => base.Length; }
}
