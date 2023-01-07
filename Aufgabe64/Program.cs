// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void PrintNumbersFromN(int N, int M) 
{
    if (N <= M)
    {
        Console.WriteLine(N);
        return;
    }
    Console.Write($"{N}, ");
    PrintNumbersFromN(N - 1, M);
}
PrintNumbersFromN(12, 1);
