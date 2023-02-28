using Lesson4;

string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
                       + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
                       + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
                       + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
                       + "posledni veta!";
                       
StringStatistics text = new StringStatistics(testovaciText);

Console.WriteLine(text.NumberOfWords());
Console.WriteLine(text.NumberOfSentences());