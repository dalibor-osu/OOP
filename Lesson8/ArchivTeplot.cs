using System.Net;

namespace Lesson8;

public class ArchivTeplot
{
    private SortedDictionary<int, RocniTeplota> _archiv;

    public ArchivTeplot()
    {
        _archiv = new SortedDictionary<int, RocniTeplota>();
    }

    public void Load(string path)
    {
        string[] lines = File.ReadAllLines(path);

        foreach (string line in lines)
        {
            int year = int.Parse(line.Split(":")[0].Trim());
            string[] temps = line.Split(":")[1].Split(";");
            List<double> teploty = new List<double>();

            foreach (string temp in temps)
            {
                teploty.Add(double.Parse(temp.Trim()));
            }
            
            _archiv.Add(year, new RocniTeplota { MesicniTeploty = teploty, Rok = year });
        }
    }

    public void Save(string path)
    {
        if (File.Exists(path))
            File.Delete(path);

        File.Create(path).Close();

        string[] saveString = GetSaveString();

        File.WriteAllLines(path, saveString);
    }

    public void Kalibrace(double value)
    {
        foreach (KeyValuePair<int, RocniTeplota> item in _archiv)
        {
            RocniTeplota rok = _archiv[item.Key];

            for (int i = 0; i < rok.MesicniTeploty.Count; i++)
            {
                rok.MesicniTeploty[i] = Math.Round(rok.MesicniTeploty[i] + value, 2);
            }
        }
    }

    public RocniTeplota Vyhledej(int rok)
    {
        return _archiv[rok];
    }

    public void TiskTeplot()
    {
        foreach (string line in GetSaveString())
        {
            Console.WriteLine(line);
        }
    }

    public void TiskPrumernychRocnichTeplot()
    {
        foreach (KeyValuePair<int,RocniTeplota> rocniTeplota in _archiv)
        {
            Console.WriteLine(rocniTeplota.Key + ":\t" + rocniTeplota.Value.PrumRocniTeplota);
        }
    }

    public void TiskPrumernychMesicnichTeplot()
    {
        List<double> prumerneTeploty = new List<double>();
        Console.Write("\nPrum.:   ");
        for (int i = 0; i < 12; i++)
        {
            double prum = Math.Round(_archiv.Sum(rocniTeplota => rocniTeplota.Value.MesicniTeploty[i]) / 12, 2);
            Console.Write(prum + "   ");
        }
        
        Console.Write("\n");
    }

    private string[] GetSaveString()
    {
        string[] saveString = new string[_archiv.Count];
        KeyValuePair<int, RocniTeplota>[] pairs = _archiv.ToArray();

        for (int i = 0; i < pairs.Length; i++)
        {
            RocniTeplota rok = pairs[i].Value;
            saveString[i] = pairs[i].Key + ":";

            for (int j = 0; j < rok.MesicniTeploty.Count; j++)
            {
                saveString[i] += " " + rok.MesicniTeploty[j];
                if (j + 1 < rok.MesicniTeploty.Count) saveString[i] += ";";
            }
        }

        return saveString;
    }
}