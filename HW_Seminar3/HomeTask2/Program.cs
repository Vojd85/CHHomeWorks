// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Напишите координату Х точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите координату Y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите координату Z точки А: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите координату Х точки Б: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите координату Y точки Б: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите координату Z точки Б: ");
int zb = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((xb - xa)*(xb - xa) + (yb - ya)*(yb - ya) + (zb - za)*(zb - za));
Console.WriteLine($"Расстояние между точками {Math.Round(result, 2)}");
