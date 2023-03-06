namespace Lesson5;

public class Autoradio
{
    private Dictionary<int, double> _predvolby = new ();
    
    public bool RadioZapnuto { get; private set; }
    public double NaladenyKmitocet { get; private set; }
    
    public Autoradio()
    {
        RadioZapnuto = false;
        NaladenyKmitocet = 0;
    }

    public void NastavPredvolbu(int cislo, double kmitocet)
    {
        _predvolby.Add(cislo, kmitocet);
    }
    
    public void PreladNaPredvolbu(int cislo)
    {
        if (!_predvolby.ContainsKey(cislo))
            throw new Exception("Predvolba neexistuje");
        
        NaladenyKmitocet = _predvolby[cislo];
    }
    
    public void ZapniVypni()
    {
        RadioZapnuto = !RadioZapnuto;
    }
    
    public override string ToString()
    {
        return $"Radio:\n" +
               $"\t\tZapnuto: {RadioZapnuto}\n" +
               $"\t\tNaladeny kmitocet: {NaladenyKmitocet}\n";
    }
}