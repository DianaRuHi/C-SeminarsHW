/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(min * rnd.NextDouble() + max * rnd.NextDouble(), 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write($"[{arr[i]} , ");
        else if (i < arr.Length - 1) Console.Write($"{arr[i]} , ");
        else Console.WriteLine($"{arr[i]}]");
    }
}

double DifferenceMaxMinArray(double[] arr)
{
    double min = arr[0], max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    return max - min;
}

double[] array = CreateArrayRndDouble(5, -10, 10);
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {DifferenceMaxMinArray(array)}");
