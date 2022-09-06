// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] newMatrix = new int[4,4];

int[,] RoundMatrix(int[,] inputMatrix, int m, int n)
{
    int [,] matrix = new int[m,n];
    int step = 1;
    {
        
        for (int j = 0; j < inputMatrix.GetLength(1); j++) 
        {
            matrix[0,j] += step;
        }
        
    }


}