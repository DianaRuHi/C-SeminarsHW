/* Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка */

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] matr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"[{matr[i, j],3} |");
            else if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],3} |");
            else Console.WriteLine($"{matr[i, j],3} ]");
        }
    }
}

void RowWithMinSum(int[,] matr)
{
    int minRow = 0;
    int sumMinRow = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sumCurrentRow = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sumCurrentRow = sumCurrentRow + matr[i, j];
        }
        if (i == 0) sumMinRow = sumCurrentRow;
        else if (sumCurrentRow < sumMinRow)
        {
            sumMinRow = sumCurrentRow;
            minRow = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой: {minRow + 1}");
}

int[,] matrix = CreateMatrixRndInt(4, 5, 0, 10);
PrintMatrix(matrix);
RowWithMinSum(matrix);

