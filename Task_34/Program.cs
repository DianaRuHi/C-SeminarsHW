/* Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая 
покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write($"[{arr[i]},");
        else if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.WriteLine($"{arr[i]}]");
    }
}

int NumberOfEven(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) result += 1;
    }
    return result;
}

int[] array = CreateArrayRndInt(10, 100, 1000);
PrintArray(array);
Console.WriteLine($"Количество четных чисел в массиве равно {NumberOfEven(array)}");

