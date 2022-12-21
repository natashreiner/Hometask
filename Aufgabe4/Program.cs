Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число C: ");
int numberC = int.Parse(Console.ReadLine());

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write("max = ");
Console.WriteLine(max);

