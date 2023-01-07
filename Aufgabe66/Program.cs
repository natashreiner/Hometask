// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N

int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");

int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine());
}

int SumFromTo(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;
    else if (N == 0) return (M * (M + 1)) / 2;
    else if (M == N) return M;
    else if (M < N) return N + SumFromTo(M, N - 1);
    else return N + SumFromTo(M, N + 1);
}

Console.WriteLine(SumFromTo(M, N));

