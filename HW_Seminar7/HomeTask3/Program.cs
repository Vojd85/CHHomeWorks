// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] GetArrayСonsole(int m, int n)
{
    int [,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine($"Bведите число {i + 1} строки: ");
            matrix[i,j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return matrix;
}

int[,] arrayConsole = GetArrayСonsole(rows, columns);
PrintArray(arrayConsole);

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < arrayConsole.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arrayConsole.GetLength(0); i++)
    {
        sum += arrayConsole[i,j];        
    }
    Console.Write($"{Math.Round((sum / rows), 2)}; ");
}