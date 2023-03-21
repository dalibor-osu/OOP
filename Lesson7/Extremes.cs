namespace Lesson7;

public abstract class Extremes
{
    public static T Biggest<T>(T[] array) where T : IComparable
    {
        T greatest = array[0];

        foreach (T obj in array)
        {
            if (greatest.CompareTo(obj) < 0) greatest = obj;
        }

        return greatest;
    }
    
    public static T Smallest<T>(T[] array) where T : IComparable
    {
        T greatest = array[0];

        foreach (T obj in array)
        {
            if (greatest.CompareTo(obj) > 0) greatest = obj;
        }

        return greatest;
    }
}