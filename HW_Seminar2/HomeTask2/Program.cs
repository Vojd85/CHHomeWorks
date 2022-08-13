// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > -100 && number < 100) Console.WriteLine($"В числе {number} третьей цифры нет");
else 
{
   if (number <= 100) number = number * -1; 
    string num = Convert.ToString(number);
    Console.WriteLine($"Третья цифра {num[2]}");
}
