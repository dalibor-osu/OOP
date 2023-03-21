namespace Lesson7;

public class Triangle : Object2D
{
    public double A { get; init; }
    public double B { get; init; }
    public double C { get; init; }
    
    public override double Area() =>
        (A + B + C) / 2;

    public override string ToString() =>
        $"Triangle (a = {A}, b = {B}, C = {C})";
}