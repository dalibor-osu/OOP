using Lesson6.Objects._2D;

namespace Lesson6.Objects._3D;

public class Pyramid : Object3D
{
    public double A { get; }
    public double Height { get; }

    public Pyramid(double a, double height)
    {
        A = a;
        Height = height;
    }


    public override void Draw() =>
        Console.WriteLine("Pyramid (a = {0}, h = {1})", A, Height);

    public override double CalculateSurface()
    {
        double sideB = Math.Sqrt(Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(A / 2, 2)) + Math.Pow(A / 2, 2));
        Triangle side = new (A, sideB, sideB);
        Rectangle baseRect = new (A, A);

        return side.CalculateArea() * 4 + baseRect.CalculateArea();
    }

    public override double CalculateVolume() =>
        (1.0 / 3.0) * (A * A) * Height;
}