namespace Lesson5;

public class Program
{
    public static void Main(string[] args)
    {
        Nakladni nakladniAuto = new (0, 100, Auto.TypPaliva.Nafta, 1000);
        Osobni osobniAuto = new (0, 50, Auto.TypPaliva.Benzin, 5);
        
        Console.WriteLine("Auta bez uprav:\n");
        Console.WriteLine(nakladniAuto);
        Console.WriteLine(osobniAuto);
        
        DemonstraceVyjimek(osobniAuto);
        DemonstraceRadia(osobniAuto);
        DemonstraceVlastnosti(osobniAuto);
    }

    private static void DemonstraceVlastnosti(Osobni osobniAuto)
    {
        Console.WriteLine("Demonstrace cteni vlastnosti osobniho auta:\n");
        Console.WriteLine("Prepravovane osoby: " + osobniAuto.PrepravovaneOsoby);
        Console.WriteLine("Max osob: " + osobniAuto.MaxOsob);
        Console.WriteLine("Radio: " + osobniAuto.Radio);
        Console.WriteLine("Palivo: " + osobniAuto.Palivo);
        Console.WriteLine("Stav nadrze: " + osobniAuto.StavNadrze);
        Console.WriteLine("Velikost nadrze: " + osobniAuto.VelikostNadrze);
    }

    private static void DemonstraceRadia(Osobni osobniAuto)
    {
        Console.WriteLine("Demonstrace radia:\n");
        osobniAuto.Radio.ZapniVypni();
        osobniAuto.Radio.NastavPredvolbu(1, 87.5);
        osobniAuto.Radio.NastavPredvolbu(2, 101);
        osobniAuto.Radio.PreladNaPredvolbu(1);
        Console.WriteLine(osobniAuto.Radio);
        osobniAuto.Radio.ZapniVypni();
        osobniAuto.Radio.PreladNaPredvolbu(2);
        Console.WriteLine(osobniAuto.Radio);
    }

    private static void DemonstraceVyjimek(Osobni osobniAuto)
    {
        Console.WriteLine("Demonstrace vyjimek na osobnim aute:\n");
        
        try
        {
            osobniAuto.Natankuj(Auto.TypPaliva.Nafta, 10);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        
        try
        {
            osobniAuto.Natankuj(Auto.TypPaliva.Benzin, 65416546504);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        try
        {
            osobniAuto.PrepravovaneOsoby = 50;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    
}