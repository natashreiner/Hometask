Console.WriteLine("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());

int count = 2;

while (count <= numberN)
{
    Console.Write($"{count}, ");
    count = count + 2;
}
