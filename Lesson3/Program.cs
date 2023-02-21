
using Lesson3;

Matrix a = new (new double[,]
{
    {1, 2},
    {4, 5}
});

Matrix b = new (new double[,] 
{
    {1, 2},
    {3, 4},
    {5, 6}
});

Matrix c = new(new double[,]
{
    {1, 2, 3},
    {4, 5, 6}
});

Matrix d = new(new double[,]
{
    {4, 6},
    {2, 1},
});

Matrix e = new(new double[,]
{
    {1, 2, 8},
    {3, 4, 1},
    {5, 6, 9}
});

Console.WriteLine("Scitani matic:\n" + (a + d));
Console.WriteLine("\nOdcitani matic:\n" + (a - d));
Console.WriteLine("\nNasobeni matic:\n" + (b * c));
Console.WriteLine("\nNasobeni matice skalarem:\n" + a * 2);
Console.WriteLine("\nPorovnani matic ==:\n" + (a == d));
Console.WriteLine("\nPorovnani matic !=:\n" + (a != d));
Console.WriteLine("\nDeterminant matice 2x2:\n" + a.Determinant());
Console.WriteLine("\nDeterminant matice 3x3:\n" + e.Determinant());
Console.WriteLine("\nUnarni operator - :\n" + (-a));

// Podle stránky https://matrixcalc.org/ vychází všechny výsledky správně