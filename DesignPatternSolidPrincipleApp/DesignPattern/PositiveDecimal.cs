namespace DesignPattern;

public struct PositiveDecimal
{
    private decimal _value;

    public PositiveDecimal(decimal value)
    {
        if (value <= 0) throw new ArgumentException("Value must be greater than zero.");
        _value = value;
    }

    public static implicit operator PositiveDecimal(decimal value)
    {
        return new PositiveDecimal(value);
    }

    public static implicit operator decimal(PositiveDecimal positiveDecimal)
    {
        return positiveDecimal._value;
    }

    public decimal Value => _value;

    public static PositiveDecimal operator +(PositiveDecimal left, PositiveDecimal right)
    {
        return new PositiveDecimal(left._value + right._value);
    }

    public static PositiveDecimal operator -(PositiveDecimal left, PositiveDecimal right)
    {
        if (left._value <= right._value) throw new InvalidOperationException("Resulting value cannot be negative.");
        return new PositiveDecimal(left._value - right._value);
    }
}
