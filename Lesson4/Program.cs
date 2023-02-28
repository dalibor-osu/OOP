using Lesson4;

string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
                       + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
                       + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
                       + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
                       + "posledni veta!";
                       
StringStatistics text = new StringStatistics(testovaciText);
Console.WriteLine(testovaciText);
Console.WriteLine("\nNumber of words: " + text.NumberOfWords());
Console.WriteLine("Number of sentences: " + text.NumberOfSentences());
Console.WriteLine("Longest words: ");
PrintArray(text.LongestWords());

Console.WriteLine("\nShortest words: ");
PrintArray(text.ShortestWords());

Console.WriteLine("\nMost frequent words: ");
PrintArray(text.MostFrequentWords());

Console.WriteLine("\nSorted words: ");
PrintArray(text.SortedWords());

void PrintArray(string[] array)
{
    Console.Write("\t");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
    }
}
