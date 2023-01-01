// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Input number");
int n = ReadInt("Number");
int sum = 0;
while (n > 0)
{
    sum += n % 10;
    n = n/10;
}
Console.WriteLine(sum);


int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

//string number = ReadInt("number").ToString();
//void PrintArray(int[] number)
//{
  //  int count = number.Length;
    //for (int i = 0; i < count; i++)
    //{
      //  Console.Write($"{number[i]}");
    //}    
    //Console.WriteLine();
//}

/*int ArrayToString(int[] number)
{
    string ArrayToString = string.Empty;
    int sum = 0;
    for(int i = 0; i < number.Length; i++)
    {
        sum = sum + number[i];
    }
    return sum;
}*?



//Console.WriteLine(sum);

/*string ArrayToString(int[] array)
{
    int sum = 0;

	for (int i = 0; i < array.Length; i++)
	{
        sum = sum + array[i];
	}
	return sum;
    Console.WriteLine(sum);
}*/



