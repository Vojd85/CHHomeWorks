// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Задан массив:");
int[,] randomArray = new int[4,5];
for (int i = 0; i < randomArray.GetLength(0); i++)
{
    for (int j = 0; j < randomArray.GetLength(1); j++)
    {
        randomArray[i,j] = new Random().Next(11);
        Console.Write(randomArray[i,j] + "\t");
    }
    Console.WriteLine();
}
Console.Write("Введите позицию искомого числа в строках: ");
int findRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите позицию искомого числа в столбцах: ");
int findColumn = Convert.ToInt32(Console.ReadLine());

if(findRow >= randomArray.GetLength(0) || findColumn >= randomArray.GetLength(1))
    Console.WriteLine("Такого числа в массиве нет");
else Console.WriteLine($"Это число {randomArray[findRow, findColumn]}");


