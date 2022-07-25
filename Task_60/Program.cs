/* Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет 
построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
int FindSameValue(int[,,] arr, int x, int y, int z)
{
    int result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (result == 0 && i == x && j == y && k == z) result = 0;
                else if (arr[i, j, k] == arr[x, y, z]) result = 1;
            }
        }
    }
    return result;
}

int[,,] Create3DArray(int x, int y, int z)
{
    int[,,] result = new int[x, y, z];
    Random rnd = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                int paper = 1;
                while (paper == 1)
                {
                    result[i, j, k] = rnd.Next(10, 100);
                    paper = FindSameValue(result, i, j, k);
                }
            }
        }
    }
    return result;
}

void Print3DArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}");
                Console.Write($"({i},{j},{k})  ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] matrix3D =Create3DArray(3, 2, 4);
Print3DArray(matrix3D);
