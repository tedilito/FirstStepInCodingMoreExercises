double r = double.Parse(Console.ReadLine());

double sKrug = Math.PI * r * r;
double pKrug = 2 * Math.PI * r;
Console.WriteLine($"<{sKrug:f2}>");
Console.WriteLine($"<{pKrug:f2}>");