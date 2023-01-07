// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

int length = ReadInt("number M");
int secondLength = ReadInt("number N");
int [,] array = GetRandomArray(length, secondLength);

PrintArray(array);

SortEveryRow(array);
Console.WriteLine();
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

void SortRow(int [,] array, int row)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[row, i] > array[row, j])
            {
                int temp = array[row, i];
                array[row, i] = array[row, j];
                array[row, j] = temp; 
            }
        }
    }
}

void SortEveryRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SortRow(array, i);
    }

}