﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


int positionA = ReadInt("position A");
int positionB = ReadInt("position B");
int[,] array = GetRandomArray(6, 6);

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
            array[i, j] = random.Next(100);
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

bool CheckPosition(int[,] array, int positionA, int positionB)
{
    if (positionA > 0 && positionB > 0 && positionA < array.GetLength(0) && positionB < array.GetLength(1))
    {
        return true;
    }
        return false;
}

if (CheckPosition(array, positionA, positionB))
{
    System.Console.WriteLine($"Значение элемента {array[positionA, positionB]}");
}
else
{
    System.Console.WriteLine("Нет такого элемента");
}

// не пойму почему пишет "нет" во все остальные позиции, если делать так
//GetPositionNumber(array, positionA, positionB);
/*void GetPositionNumber(int[,] array, int positionA, int positionB)
{
    for (int i =0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == positionA && j == positionB)
            {
                Console.WriteLine($"Значение элемента {array[i, j]}");
            }
            else 
            {
                Console.WriteLine("Нет такого элемента");
            }
        }
    }
}*/


