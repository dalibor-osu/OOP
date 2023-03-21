namespace Lesson7;

public abstract class Extremes
{
    public static T Greatest<T>(T[] array) where T : IComparable
    {
        T greatest = array[0];

        foreach (T t in array)
        {
            if (greatest.CompareTo(t) < 0) greatest = t;
        }

        return greatest;
    }
    
    public static T Smallest<T>(T[] array) where T : IComparable
    {
        T greatest = array[0];

        foreach (T t in array)
        {
            if (greatest.CompareTo(t) > 0) greatest = t;
        }

        return greatest;
    }
}