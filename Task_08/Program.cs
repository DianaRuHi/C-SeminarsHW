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
    while (count < n - 2)
    {
        Console.Write($"{count}, ");
        count += 2;
    }
}
else if (n < count)
{
    count = 0;
    while (count > n + 2)
    {
        Console.Write($"{count}, ");
        count -= 2;
    }
}

if (n == 0 || n == 2) // это для того, чтобы в конце у нечетных чисел не было запятой, как это сделать по-другому, я не знаю
{
    Console.WriteLine($"{n}");
}
else if ((Math.Abs(n % 2) == 0) && n > 1)
{
    Console.WriteLine($"{n - 2}, {n}");
}
else if (n > 1)
{
    Console.WriteLine($"{n - 1}");
}
else if ((Math.Abs(n % 2) == 0) && n < 1)
{
    Console.WriteLine($"{n + 2}, {n}");
}
else if (n < 1)
{
    Console.WriteLine($"{n + 1}");
}
