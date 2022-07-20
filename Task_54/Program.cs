/* Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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

void SortRowsInDescendingOrderOfElements(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int counter = 0; counter < matr.GetLength(1); counter++)
        {
            int maxJ = counter;
            for (int j = counter; j < matr.GetLength(1); j++)
            {

                if (matr[i, j] > matr[i, maxJ]) maxJ = j;
            }
            int temp = matr[i, counter];
            matr[i, counter] = matr[i, maxJ];
            matr[i, maxJ] = temp;
        }
    }
}

int[,] matrix = CreateMatrixRndInt(4, 5, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
SortRowsInDescendingOrderOfElements(matrix);
PrintMatrix(matrix);
