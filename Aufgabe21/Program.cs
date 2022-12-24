//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.Write("Введите координату x для точки A: ");
int xA = int.Parse(Console.ReadLine());

Console.Write("Введите координату y для точки A: ");
int yA = int.Parse(Console.ReadLine());

Console.Write("Введите координату z для точки A: ");
int zA = int.Parse(Console.ReadLine());

Console.Write("Введите координату x для точки B: ");
int xB = int.Parse(Console.ReadLine());

Console.Write("Введите координату y для точки B: ");
int yB = int.Parse(Console.ReadLine());

Console.Write("Введите координату z для точки B: ");
int zB = int.Parse(Console.ReadLine());

double distance = 0;

//√((xb - xa)2 + (yb - ya)2)

distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
Console.WriteLine(Math.Round(distance, 2));

