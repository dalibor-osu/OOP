namespace Lesson6.Objects._2D;

public class Circle : Object2D
{
    public double Diameter { get; }

    public Circle(double diameter)
    {
        Diameter = diameter;
    }
    
    public override void Draw() =>
        Console.WriteLine("Circle (d = {0})", Diameter);
    

    public override double CalculateArea() =>
        Math.PI * (Math.Pow(Diameter, 2) / 4);
}