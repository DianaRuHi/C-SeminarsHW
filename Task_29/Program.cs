/* Напишите программу, которая задаёт массив из 8 элементов, 
заполненный псевдослучайными числами и выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33] */

Console.WriteLine("Введите длину массива.");
Console.Write("length = ");
int leng = int.Parse(Console.ReadLine());

int[] Colle(int len)
{
    int[] arr = new int[len];
    var rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(-99, 100);
    }
    return arr;
}

void Prin(int[] ar)
{
    Console.Write("[");
    for (int i = 0; i < ar.Length - 1; i++)
    {
        Console.Write($"{ar[i]},");
    }
    Console.Write($"{ar[ar.Length - 1]}]");
}

int[] array = Colle(leng);
Prin(array);
