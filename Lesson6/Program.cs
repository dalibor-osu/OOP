using Lesson6.Objects;
using Lesson6.Objects._2D;
using Lesson6.Objects._3D;

namespace Lesson6;

public static class Program
{
    public static void Main(string[] args)
    {
        double totalVolume = 0;
        double totalSurface = 0;
        double totalArea = 0;
        
        GrObject[] objects =
        {
            new Circle(2),
            new Ellipse(2, 4),
            new Rectangle(3, 8),
            new Triangle(3, 4, 5),
            
            new Block(7, 8, 10),
            new Cylinder(5, 10),
            new Pyramid(2, 10),
            new Sphere(10)
        };

        foreach (GrObject grObject in objects)
        {
            grObject.Draw();

            if (grObject is Object2D object2D)
            {
                totalArea += object2D.CalculateArea();
            }

            if (grObject is Object3D object3D)
            {
                totalSurface += object3D.CalculateSurface();
                totalVolume += object3D.CalculateVolume();
            }
        }
        
        Console.WriteLine("\nTotal area: " + totalArea);
        Console.WriteLine("\nTotal volume: " + totalVolume);
        Console.WriteLine("Total surface: " + totalSurface);
    }
}

