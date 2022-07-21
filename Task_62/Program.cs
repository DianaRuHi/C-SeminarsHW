/* Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int FillRowOrColumn(int[,] matr, int iStart, int jStart, int iEnd, int jEnd, int number)
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
    return number;
}

int FillPerimeter(int[,] matr, int iStartDiagnal, int jStartDiagnal, int iEndDiagnal, int jEndDiagnal, int number)
{
    if ((iEndDiagnal - iStartDiagnal) == 0 || (jEndDiagnal - jStartDiagnal) == 0)
        number = FillRowOrColumn(matr, iStartDiagnal, jStartDiagnal, iEndDiagnal, jEndDiagnal, number);
    else if ((iEndDiagnal - iStartDiagnal) == 1)
    {
        number = FillRowOrColumn(matr, iStartDiagnal, jStartDiagnal, iStartDiagnal, jEndDiagnal, number);
        number = FillRowOrColumn(matr, iEndDiagnal, jEndDiagnal, iEndDiagnal, jStartDiagnal, number);
    }
    else
    {
        number = FillRowOrColumn(matr, iStartDiagnal, jStartDiagnal, iStartDiagnal, jEndDiagnal, number);
        number = FillRowOrColumn(matr, iStartDiagnal + 1, jEndDiagnal, iEndDiagnal, jEndDiagnal, number);
        number = FillRowOrColumn(matr, iEndDiagnal, jEndDiagnal - 1, iEndDiagnal, jStartDiagnal, number);
        number = FillRowOrColumn(matr, iEndDiagnal - 1, jStartDiagnal, iStartDiagnal + 1, jStartDiagnal, number);
    }
    return number;
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
        number = FillPerimeter(result, iStartD + i, jStartD + i, iEndD - i, jEndD - i, number);
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

int[,] matrixMagic = FillArray(6, 9);
PrintMatrix(matrixMagic);

//Вывод
//[  1 |  2 |  3 |  4 |  5 |  6 |  7 |  8 |  9 ]
//[ 26 | 27 | 28 | 29 | 30 | 31 | 32 | 33 | 10 ]
//[ 25 | 44 | 45 | 46 | 47 | 48 | 49 | 34 | 11 ]
//[ 24 | 43 | 54 | 53 | 52 | 51 | 50 | 35 | 12 ]
//[ 23 | 42 | 41 | 40 | 39 | 38 | 37 | 36 | 13 ]
//[ 22 | 21 | 20 | 19 | 18 | 17 | 16 | 15 | 14 ]
