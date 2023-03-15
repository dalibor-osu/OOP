namespace Lesson6.Objects._2D;

public class Rectangle : Object2D
{
    public double A { get; }
    public double B { get; }

    public Rectangle(double a, double b)
    {
        A = a;
        B = b;
    }

    public override void Draw() =>
        Console.WriteLine("Rectangle (A = {0}, B = {1})", A, B);

    public override double CalculateArea() =>
        A * B;
}