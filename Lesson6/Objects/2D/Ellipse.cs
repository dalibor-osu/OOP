namespace Lesson6.Objects._2D;

public class Ellipse : Object2D
{
    public double A { get; }
    public double B { get; }

    public Ellipse(double a, double b)
    {
        A = a;
        B = b;
    }

    public override void Draw() =>
        Console.WriteLine("Ellipse (A = {0}, B = {1})", A, B);

    public override double CalculateArea() =>
        Math.PI * A * B;
}