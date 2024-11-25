using System.Reflection.Metadata.Ecma335;

namespace DesignPattern.Liskov.Bad;

internal class L_BadRectangle : L_BadShape
{
    private double _length;
    public virtual double Length { get { return _length; } set { _length = value; } }

    private double _width;
    public virtual double Width { get { return _width; } set { _width = value; } }

    public override double Area { get => _length * _width; }
}
