double priceSkumriq = double.Parse(Console.ReadLine());
double priceCaca = double.Parse(Console.ReadLine());
double kgPalamud = double.Parse(Console.ReadLine());
double kgSafrid = double.Parse(Console.ReadLine());
int kgMidi = int.Parse(Console.ReadLine());


double pricePalamud = priceSkumriq + priceSkumriq * 0.60;
double priceSafrid =  priceCaca + priceCaca * 0.80;
double priceMidi = 7.50;

double totalPrice = (pricePalamud * kgPalamud) + (priceSafrid * kgSafrid) + (priceMidi * kgMidi);
Console.WriteLine($"{totalPrice:f2}");

