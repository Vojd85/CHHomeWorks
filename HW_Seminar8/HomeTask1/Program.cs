// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

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

int[,] ourMatrix = GetRandomMatrix(rows, columns);
PrintMatrix(ourMatrix);
GetRowsMaxToMinElem(ourMatrix);
Console.WriteLine();
PrintMatrix(ourMatrix);

void GetRowsMaxToMinElem (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i,k] < matrix[i,k + 1])
                {
                    int tempNumber = matrix[i,k];
                    matrix[i,k] = matrix[i,k + 1];
                    matrix[i,k + 1] = tempNumber;
                }

            }               
        }        
    }
}



// Задача 53: Задайте двумерный массив. Напишите программу которая меняет первую и последнюю строки

// void ReverseMatrix(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int temp;
//         temp = array[0,j];
//         array[0,j] = array[array.GetLength(0) - 1, j];
//         array[array.GetLength(0) - 1, j] = temp;
//     }
// }
