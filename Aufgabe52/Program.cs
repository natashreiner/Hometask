// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int length = ReadInt("number M");
int secondLength = ReadInt("number N");
int [,] array = GetRandomArray(length, secondLength);

PrintArray(array);

int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}

int [,] GetRandomArray(int length, int secondLength)
{
    int [,] array = new int [length, secondLength];
    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = random.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
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

for (int j = 0; j < array.GetLength(1); j++)
{
    double average = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        average += array[i, j];
    }
    average /= length;
    average = Math.Round(average, 2);
    Console.Write(average + "; ");
}
