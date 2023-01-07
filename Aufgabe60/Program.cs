// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента


int[,,] array = GetThreeDimensionArray(ReadInt("length 1"), ReadInt("length 2"), ReadInt("length 3"));
PrintThreeDimensionArray(array);

int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}

int[,,] GetThreeDimensionArray(int length1, int length2, int length3)
{
    int[,,] array = new int[length1, length2, length3];
    Random rnd = new Random();

    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            for (int k = 0; k < length3; k++)
            {
                int value = rnd.Next(100);
                if (!HasValueInThreeDimensionArray(array, value))
                    array[i, j, k] = value;
                else
                {
                    k--;
                }
            }
        }
    }
    return array;
}

bool HasValueInThreeDimensionArray(int[,,] array, int value)
{
    foreach (int item in array)
    {
        if (item == value)
        {
            return true;
        }
    }
    return false;
}

void PrintThreeDimensionArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{i} - {j} - {k}: {array[i, j, k]} ");
            }
        }
    }
}


