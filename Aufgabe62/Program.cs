﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int [,] array = new int[4, 4];

Console.WriteLine();
SortArray(array);
PrintArray(array);

void SortArray(int [,] array)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    

    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < array.GetLength(1) -1)
        j++;
        else if (i < j && i + j >= array.GetLength(0) -1)
        i++;
        else if (i >= j && i + j > array.GetLength(1) -1)
        j--;
        else 
        i--;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        if (array[i, j] <= 0)
            {
                Console.Write($" {array[i, j]} ");
            }
            else Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}
