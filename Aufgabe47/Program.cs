// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами

int length = ReadInt("number M");
int secondLength = ReadInt("number N");
double[,] array = GetRandomArray(length, secondLength);

PrintArray(array);


int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}

double[,] GetRandomArray(int length, int secondLength)
{
    double[,] array = new double[length, secondLength];
    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * 10, 2);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
