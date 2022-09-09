// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

System.Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

string PrintNumbersFrom(int start, int end)
{
    if (start == end && start < 0) return ("Натуральных чисел нет");
    if (start == end && start > 0) return start.ToString();
    if (start < end)
    {
        while (start < 0)
        {
            start++;
        }
        return (start + ", " + PrintNumbersFrom(start + 1, end));
    }
    if (start > end && start > 0) return (start + ", " + PrintNumbersFrom(start - 1, end));
    else return "0";
}
Console.WriteLine($"Натуральные числа от {numberM} до {numberN}: \"\"{PrintNumbersFrom(numberM, numberN)}\"\"");
