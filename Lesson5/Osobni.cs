namespace Lesson5;

public class Osobni : Auto
{
    public int MaxOsob { get; private set; }
    private int _prepravovaneOsoby;
    public int PrepravovaneOsoby
    {
        get => _prepravovaneOsoby;
        set
        {
            if (value > MaxOsob)
                throw new Exception("Prekrocen maximalni limit osob");
            
            _prepravovaneOsoby = value;
        }
    }
    
    public Osobni(double stavNadrze, double velikostNadrze, TypPaliva palivo, int maxOsob) : base()
    {
        StavNadrze = stavNadrze;
        VelikostNadrze = velikostNadrze;
        Palivo = palivo;
        MaxOsob = maxOsob;
        PrepravovaneOsoby = 0;
    }
    
    public override string ToString()
    {
        return $"Osobni auto:\n" +
               $"\tStav nadrze: {StavNadrze}\n" +
               $"\tVelikost nadrze: {VelikostNadrze}\n" +
               $"\tPalivo: {Palivo}\n" +
               $"\tMaximalni pocet osob: {MaxOsob}\n" +
               $"\tPrepravovane osoby: {PrepravovaneOsoby}\n" +
               $"\t{Radio}\n";
    }

}