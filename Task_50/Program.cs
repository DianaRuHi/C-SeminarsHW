/*  Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого 
элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1, 7 -> такого числа в массиве нет */

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

string ElementByCoordonats(int[,] matr, int x, int y)
{
    if (x > 0 && (x-1) < matr.GetLength(0) && y > 0 && (y-1) < matr.GetLength(1)) return $"{matr[x-1, y-1]}";
    else return "Такого числа в массиве нет";
}

int[,] matrix = CreateMatrixRndInt(4, 5, 0, 10);
PrintMatrix(matrix);

int posX = 1, posY = 3;
string element = ElementByCoordonats(matrix, posX, posY);
Console.WriteLine($"Значение по позиции ({posX},{posY}): {element}");
