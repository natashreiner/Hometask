// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// Нет условия про трехзначные числа, но если числа больше, результат отрицательный.

int length = ReadInt("Array length");
int[] array = GetRandomArray(length, 0, 999);

int sum = 0;

PrintArray(array);
CountSumNotEven(array);

int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

int[] GetRandomArray(int length, int minValue, int maxValue)
{
	int[] array = new int[length];
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

void CountSumNotEven(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 1)
		{
		    sum = sum + array[i];
		}
	}
	Console.WriteLine($"Сумма нечетных чисел в массиве {sum}");
}
