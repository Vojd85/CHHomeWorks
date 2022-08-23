// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Почему он в этом примере строку 82 конвертирует в числа 56 и 50?
// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int size = number.Length;
// int sum = 0;
// for ( int index = 0; index < size; index++ ) sum += Convert.ToInt32(number[index]);
// Console.WriteLine($"В числе {number} сумма цифр {sum}");

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int size = number.ToString().Length;
int sum = 0;
for (int i = 0; i < size; i++)
{
    int temp = number % 10;
    number /= 10;
    sum += temp;
}
Console.WriteLine($"Сумма цифр {sum}");