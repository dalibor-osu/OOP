namespace Lesson1;

public class TestComplex
{
    private const double EPSILON = 1E-6;

    public static void Test(Complex testedNumber, Complex expectedNumber, string testName)
    {
        if (Math.Abs(testedNumber.Realna - expectedNumber.Realna) < EPSILON && 
            Math.Abs(testedNumber.Imaginarni - expectedNumber.Imaginarni) < EPSILON)
        {
            Console.WriteLine($"Test {testName}: OK");
        }
        else
        {
            Console.WriteLine($"Test {testName}: CHYBA");
            Console.WriteLine("Ocekavana hodnota: " + expectedNumber + " | Skutecna hodnota: " + testedNumber);
        }
    }
}