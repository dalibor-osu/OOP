namespace Lesson6.Objects._2D;

public class Triangle : Object2D
{
    public double A { get; }
    public double B { get; }
    public double C { get; }

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }


    public override void Draw() =>
        Console.WriteLine("Triangle (A = {0}, B = {1}, C = {2})", A, B, C);

    public override double CalculateArea() =>
        (A + B + C) / 2;

}