// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Немного заморочился и сделал так, так как думал что надо создать функцию для любого числа


Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 10000 || number > 99999) 
{
    Console.WriteLine("Неверное число");
    Console.WriteLine("Введите пятизначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

int Rev(int Number)
{
    string array = Convert.ToString(Number);
    char[] arrayNumber = array.ToCharArray();
    Array.Reverse(arrayNumber);
    string arrayRev = new string (arrayNumber);
    Number = Convert.ToInt32(arrayRev);
    return Number;
}
int numberRev = Rev(number);
if (number == numberRev) Console.WriteLine("является палиндромом");
else Console.WriteLine("не является палиндромом");

// Попробуем через числа:

//  Console.WriteLine("Введите пятизначное число: ");
//  int number = Convert.ToInt32(Console.ReadLine());

// while (number < 10000 || number > 99999) 
// {
//     Console.WriteLine("Неверное число");
//     Console.WriteLine("Введите пятизначное число: ");
//     number = Convert.ToInt32(Console.ReadLine());
// }

// if(number/10000 == number%10 && (number%10000)/1000 == (number%100)/10)
//     System.Console.WriteLine($"является палиндромом");
// else System.Console.WriteLine($"не является палиндромом");
