// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] GetDoubleArray(int m, int n)
{
    double [,] arrayDoubleNumbers = new double[m,n];
    for (int i = 0; i < arrayDoubleNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < arrayDoubleNumbers.GetLength(1); j++)
        {
            arrayDoubleNumbers[i,j] = new Random().NextDouble() * 20 - 10;
            arrayDoubleNumbers[i,j] = Math.Round(arrayDoubleNumbers[i,j], 1);
        }
    }
    return arrayDoubleNumbers;
}

void PrintDoubleArray(double[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double[,] resultDoubleArray = GetDoubleArray(rows, columns);
PrintDoubleArray(resultDoubleArray);




