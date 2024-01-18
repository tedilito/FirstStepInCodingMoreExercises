double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());

double ploshtSide = x * y;
double prozorecZ = 1.5 * 1.5;
double sides2 = (ploshtSide * 2) - (prozorecZ * 2);
double vrata = 1.2 * 2;
double ploshtBack = x * x;
double obshtoPredaIZadna = (2 * ploshtBack) - vrata;

double totalPlosht = sides2 + obshtoPredaIZadna;
double zelenaBoq = totalPlosht / 3.4;

double pravougulnik = 2 * (x * y);
double triugulnik = 2 * (x * h / 2);

double totalPloshtTr = pravougulnik + triugulnik;
double chervenaBoq = totalPloshtTr / 4.3;

Console.WriteLine($"{zelenaBoq:f2}");
Console.WriteLine( $"{chervenaBoq:f2}");
