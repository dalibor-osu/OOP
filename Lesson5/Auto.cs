namespace Lesson5;

public abstract class Auto
{
    public enum TypPaliva
    {
        Benzin,
        Nafta
    }
    
    public double StavNadrze { get; protected set; }
    public double VelikostNadrze { get; protected set; }
    public TypPaliva Palivo { get; set; }

    public Autoradio Radio { get; private set; }

    protected Auto()
    {
        Radio = new Autoradio();
    }
    
    public void Natankuj(TypPaliva tankovanePalivo, double mnozstvi)
    {
        if (tankovanePalivo != Palivo)
            throw new Exception("Nespravne palivo");
        
        if (StavNadrze + mnozstvi > VelikostNadrze)
            throw new Exception("Nadrz preplnena");
        
        StavNadrze += mnozstvi;
    }
}