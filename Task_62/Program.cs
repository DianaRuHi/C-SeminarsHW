/* Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

void FillRowOrColumn(int[,] matr, int iStart, int jStart, int iEnd, int jEnd, int number)
{
    if (iStart <= iEnd && jStart <= jEnd)
    {
        for (int i = iStart; i <= iEnd; i++)
        {
            for (int j = jStart; j <= jEnd; j++)
            {
                matr[i, j] = number;
                number++;
            }
        }
    }
    else if (iStart >= iEnd && jStart >= jEnd)
    {
        for (int i = iStart; i >= iEnd; i--)
        {
            for (int j = jStart; j >= jEnd; j--)
            {
                matr[i, j] = number;
                number++;
            }
        }
    }
}

void FillPerimeter(int[,] matr, int iStartDiagnal, int jStartDiagnal, int iEndDiagnal, int jEndDiagnal, int number)
{
    if ((iStartDiagnal - iEndDiagnal) == 0 || (jStartDiagnal - jEndDiagnal) == 0)
        FillRowOrColumn(matr, iStartDiagnal, jStartDiagnal, iStartDiagnal, jEndDiagnal, number);
    else if ((iStartDiagnal - iEndDiagnal) == 1)
    {
        FillRowOrColumn(matr, iStartDiagnal, jStartDiagnal, iStartDiagnal, jEndDiagnal, number);
        FillRowOrColumn(matr, iStartDiagnal + 1, jEndDiagnal, iEndDiagnal, jEndDiagnal, number);
        FillRowOrColumn(matr, iEndDiagnal, jEndDiagnal - 1, iEndDiagnal, jStartDiagnal, number);
    }
    else
    {
        FillRowOrColumn(matr, iStartDiagnal, jStartDiagnal, iStartDiagnal, jEndDiagnal, number);
        FillRowOrColumn(matr, iStartDiagnal + 1, jEndDiagnal, iEndDiagnal, jEndDiagnal, number);
        FillRowOrColumn(matr, iEndDiagnal, jEndDiagnal - 1, iEndDiagnal, jStartDiagnal, number);
        FillRowOrColumn(matr, iEndDiagnal - 1, jStartDiagnal, iStartDiagnal + 1, jStartDiagnal, number);
    }
}

int[,] FillArray(int row, int collumn)
{
    int[,] result = new int[row, collumn];
    int iStartD = 0, jStartD = 0;
    int iEndD = row - 1, jEndD = collumn - 1;
    int number = 1;
    int count = (row < collumn) ? (row / 2 + row % 2) : (collumn / 2 + collumn % 2);
    for (int i = 0; i < count; i++)
    {
        FillPerimeter(result, iStartD + i, jStartD + i, iEndD - i, jEndD - i, number);
    }
    return result;
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

int[,] matrixMagic = FillArray(5, 7);
PrintMatrix(matrixMagic);

// Вывод: 
// [  1 |  2 |  3 |  4 |  5 |  6 |  7 ]
// [  3 |  1 |  2 |  3 |  4 |  5 |  1 ]
// [  2 |  1 |  1 |  2 |  3 |  1 |  2 ]
// [  1 |  4 |  3 |  2 |  1 |  2 |  3 ]
// [  6 |  5 |  4 |  3 |  2 |  1 |  4 ]
