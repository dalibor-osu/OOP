namespace Lesson7;

public abstract class Object2D : I2D, IComparable
{
    public abstract double Area();

    public int CompareTo(object? obj)
    {
        if (obj == null) return 1;
        if (obj is not Object2D otherObject) throw new ArgumentException("Object is not a Object2D");

        return Area().CompareTo(otherObject.Area());
    }
}