namespace Lesson2;

public class Complex
{
    public double Realna { get; }
    public double Imaginarni { get; }
    
    public Complex(double realna, double imaginarni)
    {
        Realna = realna;
        Imaginarni = imaginarni;
    }
    
    public static Complex operator -(Complex c) => 
        new (-c.Realna, -c.Imaginarni);

    public static Complex operator +(Complex c1, Complex c2) => 
        new (c1.Realna + c2.Realna, c1.Imaginarni + c2.Imaginarni);

    public static Complex operator -(Complex c1, Complex c2) =>
        new (c1.Realna - c2.Realna, c1.Imaginarni - c2.Imaginarni);

    public static Complex operator *(Complex c1, Complex c2) =>
        new (c1.Realna * c2.Realna - c1.Imaginarni * c2.Imaginarni, c1.Realna * c2.Imaginarni + c1.Imaginarni * c2.Realna);
    
    // Source: https://www2.karlin.mff.cuni.cz/~portal/komplexni_cisla/?page=algebraicky-tvar-operace
    public static Complex operator /(Complex c1, Complex c2) 
    {
        double denominator = c2.Realna * c2.Realna + c2.Imaginarni * c2.Imaginarni;
        double numeratorA = c1.Realna * c2.Realna + c1.Imaginarni * c2.Imaginarni;
        double numeratorB = c1.Imaginarni * c2.Realna - c1.Realna * c2.Imaginarni;
        
        return new Complex(numeratorA / denominator, numeratorB / denominator);
    }

    public static bool operator ==(Complex c1, Complex c2) =>
        (c1.Realna == c2.Realna) && (c1.Imaginarni == c2.Imaginarni);
    

    public static bool operator !=(Complex c1, Complex c2) => 
        !(c1 == c2);
    
    public Complex ComplexConjugate() => 
        new (Realna, -Imaginarni);

    public double Modulus() => 
        Math.Sqrt(Math.Pow(Realna, 2) + Math.Pow(Imaginarni, 2));

    // Source: https://cs.wikipedia.org/wiki/Komplexn%C3%AD_%C4%8D%C3%ADslo
    public double Argument()
    {
        return Realna switch
        {
            0 when Imaginarni > 0 => Math.PI / 2,
            0 when Imaginarni < 0 => -Math.PI / 2,
            0 when Imaginarni == 0 => 0,
            < 0 when Imaginarni >= 0 => Math.Atan(Imaginarni / Realna) + Math.PI,
            < 0 when Imaginarni < 0 => Math.Atan(Imaginarni / Realna) - Math.PI,
            _ => Math.Atan(Imaginarni / Realna)
        };
    }

    public override string ToString() =>
        Realna + (Imaginarni < 0 ? " - " : " + ") + Math.Abs(Imaginarni) + "i";
    
}