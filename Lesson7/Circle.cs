namespace Lesson7;

public class Circle : Object2D
{
    public double Diameter { get; init; }

    public override double Area() => 
        Math.PI * Math.Pow(Diameter / 2, 2);

    public override string ToString() =>
        $"Circle (d = {Diameter})";
}