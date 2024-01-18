double w = double.Parse(Console.ReadLine()) * 100;
double h = double.Parse(Console.ReadLine()) * 100;
int w1 = (int)w;
int h1 = (int)h - 100;    

int sizeW = 120;
 int sizeH = 70;

int rabMqstoW = w1 / sizeW;
int rabMqstoH = h1 / sizeH;

int countMesta = (rabMqstoW * rabMqstoH) - 3;
Console.WriteLine(countMesta);
