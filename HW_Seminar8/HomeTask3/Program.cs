// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк первой матрицы: ");
int rowsFirst = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов первой матрицы: ");
int columnsFirst = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов второй матрицы: ");
int columnsSec = Convert.ToInt32(Console.ReadLine());

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
int [,] firstMatrix = GetRandomMatrix(rowsFirst, columnsFirst);
int [,] secondMatrix = GetRandomMatrix(columnsFirst, columnsSec);
int[,] powerMatrix = PowMatrix(firstMatrix, secondMatrix);

PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
Console.WriteLine("Результат");
PrintMatrix(powerMatrix);

int[,] PowMatrix (int[,] inFirstMatrix, int[,] inSecMatrix)
{
    int[,] resultMatrix = new int[inFirstMatrix.GetLength(0), inSecMatrix.GetLength(1)];
    for (int i = 0; i < inFirstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inSecMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inSecMatrix.GetLength(0); k++)
            {
                resultMatrix[i,j] += inFirstMatrix[i,k] * inSecMatrix[k,j];
            } 
        }
    }
    return resultMatrix;
}

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
