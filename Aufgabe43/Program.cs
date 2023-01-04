// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double b1 = ReadInt("Number b1");
double k1 = ReadInt("Number k1");
double b2 = ReadInt("Number b2");
double k2 = ReadInt("Number k2");
double x = 0;
double y = 0;


int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}

    if ((k1 == k2) && (b1 == b2))
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if ((k1 == k2))
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
        Console.WriteLine($"Точка пересечения {x}, {y}");
    }
    





