namespace Lesson4;

public class StringStatistics
{
    private string _text;
    
    public StringStatistics(string text)
    {
        _text = text;
    }
    
    public int NumberOfWords()
    {
        int numberOfWords = 0;
        bool isWord = false;
        
        // Kontrola každého znaku v textu
        foreach (char character in _text)
        {
            // Pokud znak není písmeno, zakončíme slovo
            if (char.IsLetter(character))
            {
                // Pokud je promněnná isWord nastavena na true, nacházíme se stále v jednom slově a pokračujeme dál
                if (isWord)
                    continue;
                
                // Pokud je proměnná isWord == false, tak jsme došli k dalšímu slovu
                // Přičteme počet slov a nastavíme proměnnou isWord na true
                numberOfWords++;
                isWord = true;
            }
            else
            {
                isWord = false;
            }
        }
        
        return numberOfWords;
    }
    
    public int NumberOfRows() =>
        // Vracíme počet znaků LF v textu pomocí LINQ
        _text.Count(c => c =='\n');
    
    public int NumberOfSentences()
    {
        int numberOfSentences = 0;
        
        for (int i = 0; i < _text.Length; i++)
        {
            // Pokud znak není tečka, vykřičník nebo otazník, pokračujeme dál
            if (_text[i] is not '.' and not '!' and not '?')
                continue;

            int offset = 1;
            
            // Hledáme další písmeno, pokud je velké, jedná se o novou větu
            while (true)
            {
                // Pokud dojdeme na konec textu, jedná se o poslední větu
                if (i + offset > _text.Length - 1)
                {
                    numberOfSentences++;
                    break;
                }
                
                // Pokud znak není písmeno, můžeme ho přeskočit
                if (!char.IsLetter(_text[i + offset]))
                {
                    offset++;
                    continue;
                }
                
                // Pokud je znak malé písmeno, nejedná se o další větu
                if (char.IsLower(_text[i + offset]))
                {
                    break;
                }
                
                numberOfSentences++;
                break;
            }
        }
        
        return numberOfSentences;
    }
    
    public string[] LongestWords()
    {
        // Rozdělíme text na jednotlivá slova na základě mezer, interpunkce a nových řádků
        string[] words = _text.Split(' ', '(', ')', '.', ',', '!', '?', ';', ':', '"', '\'', '\n', '\t');
        // Pomocí LINQ najdeme pouze řetězce, které nejsou prázdné a z nich vybereme délku nejdelšího slova
        int longestWordLength = words.Where(w => w != "").Select(word => word.Length).Prepend(0).Max();
        // Pomocí LINQ vrátíme slova, která odpovídají délce nejdelšího slova
        return words.Where(w => w.Length == longestWordLength).ToArray();
    }
    
    public string[] ShortestWords()
    {
        // Stejné jako u LongestWords
        string[] words = _text.Split(' ', '(', ')', '.', ',', '!', '?', ';', ':', '"', '\'', '\n', '\t');
        // Místo Max() použijeme Min()
        int shortestWordLength = words.Where(w => w != "").Select(word => word.Length).Prepend(int.MaxValue).Min();
        return words.Where(w => w.Length == shortestWordLength).ToArray();
    }
    
    public string[] MostFrequentWords()
    {
        string[] words = _text.Split(' ', '(', ')', '.', ',', '!', '?', ';', ':', '"', '\'', '\n', '\t');
        // Pomocí LINQ nejprce seřadíme stejná slova za sebe pomocí GroupBy a následně vytvoříme nový objekt, který obsahuje slovo a jeho počet
        var wordCount = words.Where(w => w != "").GroupBy(w => w).Select(g => new {Word = g.Key, Count = g.Count()});
        // Pomocí LINQ najdeme největší počet opakujících se slov
        int mostFrequentWordCount = wordCount.Select(w => w.Count).Prepend(0).Max();
        // Stejně jako u LongestWords a ShortestWords vrátíme slova, která odpovídají počtu nejčastějších slov
        return wordCount.Where(w => w.Count == mostFrequentWordCount).Select(w => w.Word).ToArray();
    }
    
    public string[] SortedWords()
    {
        string[] words = _text.Split(' ', '(', ')', '.', ',', '!', '?', ';', ':', '"', '\'', '\n', '\t');
        // Pomomocí LINQ seřadíme slova pomocí OrderBy
        return words.Where(w => w != "").OrderBy(w => w).ToArray();
    }
}