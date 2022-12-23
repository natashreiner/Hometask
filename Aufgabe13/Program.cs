Console.WriteLine("введите число");
int N = int.Parse(Console.ReadLine());
int b = 0;
if(N > 100)
{
    while(N > 1000)
    {
        N = N / 10;
    }
    Console.WriteLine($"Третье число {b = N % 10}");
}
else Console.WriteLine("Третьего числа нет");



