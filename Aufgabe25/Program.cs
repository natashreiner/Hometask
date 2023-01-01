//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

void Main()
{
    bool isWorking = true;
    while (isWorking)
    {
        Console.Write("Input command: ");
        switch (Console.ReadLine())
        {
            case "Task25": Task25(); break;
            case "exit": isWorking = false; break;
        }
    }
}

void Task25()
{
    Console.WriteLine("Task 25");

    int numbA = ReadInt("First number (A)");
    int numbB = ReadInt("Second number (B)");

    Console.WriteLine($"Степень {numbB} от числа {numbA} равна {Pow(numbA, numbB)}");
}

int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}

int Pow(int firstNumber, int secondNumber)
{
    int result = 1;
    for (int i = 0; i < secondNumber; i++)
    {
        result *= firstNumber;
    }
    return result;
}

//int ReadInt()
//{
  //  return int.Parse(Console.ReadLine());
//}
