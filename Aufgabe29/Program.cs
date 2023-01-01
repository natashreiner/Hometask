//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//мое решение, по аналогии с лекцией

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

// как было на семинаре, докопалась до аргументов метода ReadInt, не смогла запустить, хоть убейся

/*void Main()
{
    bool isWorking = true;
    while (isWorking)
    {
        Console.Write("Input command: ");
        switch (Console.ReadLine())
        {
            case "Task29": Task29(); break;
            case "exit": isWorking = false; break;
        }
    }
}

void Task29()
{
    Console.WriteLine("Task29");

    int[] array = GetArray(ReadInt("array length"));

    Console.WriteLine(ArrayToString(array));
}

int ReadInt()
{
    return int.Parse(Console.ReadLine());
}

int[] GetArray(int length)
{
    int[] array = new int [length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = ReadInt($"elemnt {i}");
    }
    return array;
}

string ArrayToString(int[] array)
{
    string result = string.Empty;

    for(int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]}, ";
    }
    return result;
}*/



