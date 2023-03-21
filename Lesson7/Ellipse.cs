namespace Lesson7;

public class Ellipse : Object2D
{
    public double X { get; init; }
    public double Y { get; init; }

    public override double Area() =>
        Math.PI * X * Y;

    public override string ToString() =>
        $"Ellipse (x = {X}, y = {Y})";
}