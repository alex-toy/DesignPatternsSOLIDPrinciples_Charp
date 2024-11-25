namespace DesignPattern.OpenClose.Bad;

internal class BadShape
{
    public ShapeType ShapeType { get; set; }
    public double Radius { get; set; }
    public double Length { get; set; }
    public double Width { get; set; }

    public double CalculateArea()
    {
        return ShapeType switch
        {
            ShapeType.Rectangle => Length * Width,
            ShapeType.RectangleTriangle => Length * Width / 2,
            ShapeType.Circle => Math.PI * Math.Pow(Radius, 2),
            _ => throw new InvalidOperationException()
        };
    }
}
