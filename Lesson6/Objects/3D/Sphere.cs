namespace Lesson6.Objects._3D;

public class Sphere : Object3D
{
    public double Diameter { get; }

    public Sphere(double diameter)
    {
        Diameter = diameter;
    }


    public override void Draw() =>
        Console.WriteLine("Sphere (d = {0})", Diameter);

    public override double CalculateSurface() =>
        4 * Math.PI * (Math.Pow(Diameter, 2) / 4);

    public override double CalculateVolume() =>
        (4.0 / 3.0) * Math.PI * Math.Pow(Diameter / 2, 3);
}