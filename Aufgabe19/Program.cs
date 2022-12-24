// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int value = int.Parse(Console.ReadLine());

    int a = value / 10000;
    int b = (value / 1000) % 10;
    int c = (value / 100) % 10;
    int d = (value / 10) % 10;
    int e = value % 10;

if(a == e)
    {
        if(b == d)
        {
        Console.WriteLine("палиндром");
        }
    }
    else
    {
        Console.WriteLine("не палиндром");
    }

