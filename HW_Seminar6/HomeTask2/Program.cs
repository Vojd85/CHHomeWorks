// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.Write("Введите значение k1 для первой прямой: ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите значение b1 для первой прямой: ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите значение k2 для второй прямой: ");
double k2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите значение b2 для второй прямой: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = (b1 - b2) / (k2 - k1);
double y = k1 * x + b1;
if(k1 == k2) Console.WriteLine("Прямые не пересекаются");
else Console.WriteLine($"Точка пересечения [{x};{y}]");

// Не хватило времени продумать, если линии являются одной...