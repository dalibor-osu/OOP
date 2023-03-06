namespace Lesson5;

public class Nakladni : Auto
{
    public double MaxNaklad { get; private set; }
    private double _prepravovanyNaklad;

    public double PrepravovanyNaklad
    {
        get => _prepravovanyNaklad;
        set
        {
            if (value > MaxNaklad)
                throw new Exception("Prekrocen maximalni limit nakladu");
            
            _prepravovanyNaklad = value;
        }
    }
    
    public Nakladni(double stavNadrze, double velikostNadrze, TypPaliva palivo, double maxNaklad) : base()
    {
        StavNadrze = stavNadrze;
        VelikostNadrze = velikostNadrze;
        Palivo = palivo;
        MaxNaklad = maxNaklad;
        PrepravovanyNaklad = 0;
    }
    
    public override string ToString()
    {
        return $"Nakladni auto:\n" +
               $"\tStav nadrze: {StavNadrze}\n" +
               $"\tVelikost nadrze: {VelikostNadrze}\n" +
               $"\tPalivo: {Palivo}\n" +
               $"\tMaximalni naklad: {MaxNaklad}\n" +
               $"\tPrepravovany naklad: {PrepravovanyNaklad}\n" +
               $"\t{Radio}\n";
    }
}