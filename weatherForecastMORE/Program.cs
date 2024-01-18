using System.Runtime.CompilerServices;

double deegresOutSide = double.Parse(Console.ReadLine());


if (deegresOutSide >= 26.00 && deegresOutSide <=35.00)
{
    Console.WriteLine("Hot");
}
else if (deegresOutSide >= 20.1 && deegresOutSide <=25.9)
{
    Console.WriteLine("Warm");
}
else if (deegresOutSide >= 15.00 && deegresOutSide <= 20.00)
{
    Console.WriteLine("Mild");
}
else if (deegresOutSide >= 12 && deegresOutSide <= 14.9)
{
    Console.WriteLine("Cool");
}
else if (deegresOutSide >= 5 && deegresOutSide <= 11.9)
{
    Console.WriteLine("Cold");
}
else
{
    Console.WriteLine("unknown");
}