namespace Lesson6.Objects._3D;

public class Block : Object3D
{
    public double A { get; }
    public double B { get; }
    public double C { get; }

    public Block(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }


    public override void Draw() =>
        Console.WriteLine("Block (A = {0}, B = {1}, C = {2})", A, B, C);

    public override double CalculateSurface() =>
        2 * A * B + 2 * B * C + 2 * A * C;

    public override double CalculateVolume() =>
        A * B * C;
}