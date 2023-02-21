using Lesson2;

Complex numberA = new(2.98, 1.45);
Complex numberB = new(4.23, -1.67);

Complex expectedAddition = new(7.21, -0.22);
Complex expectedSubtraction = new(-1.25, 3.12);
Complex expectedMultiplication = new(15.0269, 1.1569);
Complex expectedDivision = new(0.4924088, 0.5371921);
Complex expectedMinusA = new(-2.98, -1.45);
Complex expectedConjugateA = new(2.98, -1.45);

TestComplex.Test(numberA + numberB, expectedAddition, "Scitani");
TestComplex.Test(numberA - numberB, expectedSubtraction, "Odecitani");
TestComplex.Test(numberA * numberB, expectedMultiplication, "Nasobeni");
TestComplex.Test(numberA / numberB, expectedDivision, "Deleni");
TestComplex.Test(-numberA, expectedMinusA, "Unarni -");
TestComplex.Test(numberA.ComplexConjugate(), expectedConjugateA, "Komplexni sdruzeni");

Console.WriteLine("Vysledek operatoru ==: " + (numberA == numberB));
Console.WriteLine("Vysledek operatoru !=: " + (numberA != numberB));
Console.WriteLine("Vysledek modulu cisla A: " + numberA.Modulus());
Console.WriteLine("Vysledek argumentu cisla A: " + numberA.Argument() + " rad, " + numberA.Argument() * 180 / Math.PI + "°");

