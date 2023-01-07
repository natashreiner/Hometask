// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n

int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");

int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akkerman(m-1, 1);
    else return Akkerman(m-1, Akkerman(m, n - 1));
}

Console.WriteLine(Akkerman(m, n));