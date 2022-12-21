Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

int max = 0;

if (numberA > numberB)
{
    max = numberA;
}
else 
{
    max = numberB;
}
Console.Write("max = ");
Console.WriteLine(max);
