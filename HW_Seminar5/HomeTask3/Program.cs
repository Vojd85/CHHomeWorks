// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size = 10;
double[]array = new double[size];
for(int i = 0; i < size; i++)
{
    array[i] = (new Random().NextDouble()) * 100;
    array[i] = Math.Round(array[i], 2);
}
double min = array[0];
double max = array[0];
for(int i = 0; i < size; i++)
{
    if(array[i] > max) max = array[i];
    if(array[i] < min) min = array[i];
}
Console.WriteLine($"В массиве [{String.Join(", ", array)}]");
Console.WriteLine($"разница между максимальным значением {max} и минимальным {min} составляет {max - min}");