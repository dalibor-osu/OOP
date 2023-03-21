namespace Lesson7;

public class Square : Object2D
{
    public double Side { get; init; }

    public override double Area() =>
        Math.Pow(Side, 2);

    public override string ToString() =>
        $"Square (Side = {Side})";
}