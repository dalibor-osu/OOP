using Lesson7;

int[] ints = { 1, 3, 5, 7, 9 };

Console.WriteLine("Biggest int: " + Extremes.Biggest(ints).ToString());
Console.WriteLine("Smallest int: " + Extremes.Smallest(ints).ToString());
Console.WriteLine("");


string[] strings = { "This sentence is the longest sentence in this array", "short", "e", "6s4a58g41", "okijsdoh" };

// U typu string metoda CompareTo neporovnává délku řetězce podle dokumentace https://learn.microsoft.com/en-us/dotnet/api/system.string.compareto?view=net-6.0
Console.WriteLine("Biggest string: " + Extremes.Biggest(strings).ToString());
Console.WriteLine("Smallest string: " + Extremes.Smallest(strings).ToString());
Console.WriteLine("");


Circle[] circles =
{
    new() { Diameter = 150 },
    new() { Diameter = 4 },
    new() { Diameter = 19 },
    new() { Diameter = 11 },
    new() { Diameter = 2 }
};

Console.WriteLine("Biggest circle: " + Extremes.Biggest(circles).ToString());
Console.WriteLine("Smallest circle: " + Extremes.Smallest(circles).ToString());
Console.WriteLine("");


Rectangle[] rectangles =
{
    new() { A = 50, B = 91 },
    new() { A = 65849, B = 9041 },
    new() { A = 451, B = 124 },
    new() { A = 8, B = 4 },
    new() { A = 995, B = 1 },
};

Console.WriteLine("Biggest rectangle: " + Extremes.Biggest(rectangles).ToString());
Console.WriteLine("Smallest rectangle: " + Extremes.Smallest(rectangles).ToString());
Console.WriteLine("");


Square[] squares =
{
    new() { Side = 10 },
    new() { Side = 24 },
    new() { Side = 1 },
    new() { Side = 150 },
    new() { Side = 24 }
};

Console.WriteLine("Biggest square: " + Extremes.Biggest(squares).ToString());
Console.WriteLine("Smallest square: " + Extremes.Smallest(squares).ToString());
Console.WriteLine("");

// Některé trojúhelníky nejsou platné, ale funkcionalitu CompareTo to nijak neovlivní
Triangle[] triangles =
{
    new() { A = 10, B = 18798, C = 65812 },
    new() { A = 86, B = 814, C = 6514 },
    new() { A = 187, B = 111, C = 6844 },
    new() { A = 984, B = 1747, C = 985421 },
    new() { A = 18564, B = 18, C = 65147 }
};

Console.WriteLine("Biggest triangle: " + Extremes.Biggest(triangles).ToString());
Console.WriteLine("Smallest triangle: " + Extremes.Smallest(triangles).ToString());
Console.WriteLine("");


Ellipse[] ellipses =
{
    new() {X = 50, Y = 219},
    new() {X = 994, Y = 746},
    new() {X = 7, Y = 1},
    new() {X = 4154, Y = 5648},
    new() {X = 511, Y = 874}
};

Console.WriteLine("Biggest ellipse: " + Extremes.Biggest(ellipses).ToString());
Console.WriteLine("Smallest ellipse: " + Extremes.Smallest(ellipses).ToString());
Console.WriteLine("");


Object2D[] objects2D =
{
    new Triangle { A = 86, B = 814, C = 6514 },
    new Ellipse {X = 50, Y = 219},
    new Square { Side = 10 },
    new Rectangle { A = 540, B = 191 },
    new Rectangle { A = 50, B = 941 },
    new Circle { Diameter = 150 }
};

Console.WriteLine("Biggest object: " + Extremes.Biggest(objects2D).ToString());
Console.WriteLine("Smallest object: " + Extremes.Smallest(objects2D).ToString());
Console.WriteLine("");