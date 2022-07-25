/* Задайте значения M и N. Напишите программу, которая 
выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */

Console.WriteLine("Введите число:");
Console.Write("M = ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
Console.Write("N = ");
int num2 = Convert.ToInt32(Console.ReadLine());

void NumbersMN(int m, int n)
{
    if (m <= n)
    {
        Console.Write($"{m} ");
        if (m == n) return;
        NumbersMN(m + 1, n);
    }
    else if (m > n)
    {
        Console.Write($"{m} ");
        NumbersMN(m - 1, n);
    }
}

NumbersMN(num1, num2);
