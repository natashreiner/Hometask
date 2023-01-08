// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц

int lengthA = ReadInt("Количество строк 1 (и 2) матрицы: ");
int lengthB = ReadInt("Количество столбцов 1 матрицы: ");
int lengthC = ReadInt("Количество столбцов 2 матрицы: ");

int [,] matrix1 = GetMatrix(lengthA, lengthB);
int [,] matrix2 = GetMatrix(lengthA, lengthC);

PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();

Console.Write("Результат умножения матриц: ");
Console.WriteLine();
int [,] resultMatrix = GetResultMatrix(matrix1, matrix2);
PrintMatrix(resultMatrix);

int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}

int [,] GetMatrix(int lengthA, int lengthB)
{
    int [,] matrix = new int [lengthA, lengthB];
    Random random = new Random();

    for (int i = 0; i < lengthA; i++)
    {
        for (int j = 0; j < lengthB; j++)
        {
            matrix[i, j] = random.Next(10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int [,] GetResultMatrix(int [,] matrix1, int[,] matrix2)
{
    int [,] resultMatrix = new int [lengthB, lengthC];

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int product = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                product += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = product;
        }
    }
    return resultMatrix;
}
