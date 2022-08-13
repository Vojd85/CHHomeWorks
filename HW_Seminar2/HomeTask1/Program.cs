// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Нужно сделать через числа, без индексов строк.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 100 || number > 999) 
{
    Console.WriteLine("Неверное число");
    Console.WriteLine("Введите трехзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
int secondDigit = (number/10) % 10;
Console.WriteLine($"Вторая цифра числа {number} это {secondDigit}");
