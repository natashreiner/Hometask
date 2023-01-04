// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// Не знаю как это сделать с вещественными числами, пока никак не догадываюсь. Сделала с целыми.
// Посмотрела следующий семинар, сделала с вещественными (сама пыталась абсолюно везде поменять 
// int на double, получалась ерунда)


int length = ReadInt("Array length");
double [] array = GetRandomArray(length);

PrintArray(array);
GetDiff(array);


int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

double [] GetRandomArray(int length)
{
	double [] array = new double [length];
	Random random = new Random();

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(1, 100) + random.NextDouble();
	}

	return array;
}

void PrintArray(double [] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{Math.Round(array[i], 2)}, ");
	}
}

void GetDiff(double [] array)
{
	double max = array[0];
	double min = array[0];
	double diff = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
        min = array[i];
        }
        if (array[i] > max)
        {;
        max = array[i];
        }
        diff = max - min;
    }
	Console.WriteLine($"Разница между {max} и {min} равна {diff}");
}

/*int max = 0;
int min = 0;
int diff = 0;

int length = ReadInt("Array length");
int [] array = GetRandomArray(length, -50, 50);

PrintArray(array);
GetDiff(array);
Console.WriteLine($"Разница между {max} и {min} равна {diff}");

int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

int [] GetRandomArray(int length, int minValue, int maxValue)
{
	int [] array = new int [length];
	Random random = new Random();

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(minValue, maxValue + 1);
	}

	return array;
}

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}, ");
	}
}

void GetDiff(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
        min = array[i];
        }
        if (array[i] > max)
        {;
        max = array[i];
        }
        diff = max - min;
    }
}*/
