Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());

int div = numberA%2;


if (div == 1)
{
    Console.WriteLine("нечетное");
}
else
{
    Console.WriteLine("четное");
}
