/* Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет 
построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

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
                // Думаю, тут можно использовать какую-нибудь функцию F(x,y,z) 
                // с однозначным отображением в множество двузначных чисел,
                // но я ни одной такой не знаю..
                int paper = 0;
                while (paper == 0)
                {
                    result[i, j, k] = rnd.Next(10, 100);
                    paper = 1;
                    for (int i1 = 0; i1 <= i; i1++)
                    {
                        for (int j1 = 0; j1 <= j; j1++)
                        {
                            for (int k1 = 0; k1 < k; k1++)
                            {
                                if (result[i, j, k] == result[i1, j1, k1]) paper = 0;
                            }
                        }
                    }

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

int[,,] matrix3D = Create3DArray(3, 2, 4);
Print3DArray(matrix3D);
