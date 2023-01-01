//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void PrintArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random() .Next(1,8);
    }
}

int[] arr = new int[8];
PrintArray(arr);
FillArray(arr);
Console.WriteLine();
PrintArray(arr);
