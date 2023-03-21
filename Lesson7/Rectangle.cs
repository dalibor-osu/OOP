namespace Lesson7;

public class Rectangle : Object2D
{
    public double A { get; init; }
    public double B { get; init; }

    public override double Area() =>
        A * B;

    public override string ToString() =>
        $"Rectangle (A = {A}, B = {B})";
}