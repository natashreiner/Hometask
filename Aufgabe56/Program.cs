// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int length = ReadInt("number M");
int secondLength = ReadInt("number N");
int [,] array = GetRandomArray(length, secondLength);

PrintArray(array);

Console.WriteLine();


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

int SumInRow(int [,] array, int i)
{
    int rowSum = array[i, 0]; 

    for (int j = 1; j < array.GetLength(1); j++)
    {
        {
            rowSum += array[i, j];  
        }
    }
    return rowSum;
}
    
    
int minimalSum = 0;
int rowSum = SumInRow(array, 0);

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempRowSum = SumInRow(array, i);
        if (rowSum > tempRowSum)
        {
            rowSum = tempRowSum;
            minimalSum = i;
        }
    }
      
Console.WriteLine($"Минимальная сумма {rowSum} в строке {minimalSum + 1}");