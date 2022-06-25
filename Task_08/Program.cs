/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите число.");
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (n == 1)
{
    Console.WriteLine("Нет таких четных чисел.");
}
else if (n >= count)
{
    while (count <= n)
    {
        Console.Write($"{count}");
        if (count < n - 1)
        {
            Console.Write(", ");
        }
        count += 2;
    }
}
else if (n <= count)
{
    count = n - n % 2;
    while (count <= 0)
    {
        Console.Write($"{count}");
        if (count != 0)
        {
            Console.Write(", ");
        }
        count += 2;
    }
}
