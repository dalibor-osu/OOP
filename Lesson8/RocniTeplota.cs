namespace Lesson8;

public class RocniTeplota
{
    public int Rok { get; set; }
    public List<double> MesicniTeploty { get; set; }

    public double MaxTeplota => MesicniTeploty.Max();
    public double MinTeplota => MesicniTeploty.Min();
    public double PrumRocniTeplota => MesicniTeploty.Average();

    public RocniTeplota()
    {
        MesicniTeploty = new List<double>();
    }
}