namespace Lesson6.Objects._3D;

public class Cylinder : Object3D
{
    public double Diameter { get; }
    public double Height { get; }

    public Cylinder(double diameter, double height)
    {
        Diameter = diameter;
        Height = height;
    }

    public override void Draw() =>
        Console.WriteLine("Cylinder (d = {0}, h = {1})", Diameter, Height);

    public override double CalculateSurface() =>
        2 * Math.PI * (Diameter / 2) * Height + 2 * Math.PI * (Math.Pow(Diameter, 2) / 4);

    public override double CalculateVolume() =>
        Math.PI * (Math.Pow(Diameter, 2) / 4) * Height;
}