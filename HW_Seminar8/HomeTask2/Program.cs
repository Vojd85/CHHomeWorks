// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
while (rows == columns){
    Console.Write("Введите другое число: ");
    columns = Convert.ToInt32(Console.ReadLine());
}

int [,] GetRandomMatrix(int m, int n)
{
    int [,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(11);
        }
    }
    return matrix;
}

int[,] ourMatrix = GetRandomMatrix(rows, columns);

PrintMatrix(ourMatrix);
MinSumRows(ourMatrix);

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); // "\t" - Tab
        }
        Console.WriteLine();
    }
}

void MinSumRows (int[,] inputMatrix)
{
    int Sum = int.MaxValue;
    int result = 0;
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {  
        int rowSum = 0;
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            rowSum += inputMatrix[i,j];
        }
        if (rowSum < Sum)
        {
            Sum = rowSum;
            result = i;
        }
    }
    Console.WriteLine($"{result + 1} строка");
}