double cenaVeg = double.Parse(Console.ReadLine());
double cenaFruit = double.Parse(Console.ReadLine()) ;
int kgVeg = int.Parse(Console.ReadLine());
int kgFruit = int.Parse(Console.ReadLine());

double sumVeg = cenaVeg  * kgVeg;

double sumFruit = cenaFruit  * kgFruit;

double totalSum = sumVeg + sumFruit;
Console.WriteLine($"{totalSum / 1.94:f2}");
