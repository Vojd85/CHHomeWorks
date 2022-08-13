// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число, соответствующее дню недели: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 1 || number > 7)
{
    Console.WriteLine("Неверное число! Введите число от 1 до 7 включительно: ");
    number = Convert.ToInt32(Console.ReadLine());
}
if (number >= 1 && number <= 5) Console.WriteLine("Это рабочий день");
else Console.WriteLine("Это выходной день! Пора отдыхать)))");


