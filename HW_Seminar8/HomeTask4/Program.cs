// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите глубину массива: ");
int deep = Convert.ToInt32(Console.ReadLine());



int[,,] theCube = GetNextCube(rows, columns, deep);

int [,,] GetNextCube(int m, int n, int d)
{
    int [,,] matrix = new int[m,n,d];
    int step = 3;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int h = 0; h < matrix.GetLength(2); h++)
            {
                matrix[i,j,h] = 10 + step;
                step++;
            }
        }
    }
    return matrix;
}

PrintCube(theCube);

void PrintCube(int[,,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            for (int d = 0; d < inputMatrix.GetLength(2); d++)
            {
                System.Console.Write($"{inputMatrix[i,j,d]}({i},{j},{d})   ");
            }
            Console.WriteLine();
            
        }
        
    }
}