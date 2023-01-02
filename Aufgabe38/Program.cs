// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// Не знаю как это сделать с вещественными числами, пока никак не догадываюсь. Сделала с целыми.

int max = 0;
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
}
