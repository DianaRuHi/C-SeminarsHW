/* Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите число:");
Console.Write("M = ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
Console.Write("N = ");
int num2 = Convert.ToInt32(Console.ReadLine());

void SumFromMToN(int m, int n, int inputHere0)
{
    int sum = inputHere0;
    if (m < 0) m = 0;
    if (n < 0) n = 0;
    if (m < n)
    {
        sum += n;
        SumFromMToN(m, n - 1, sum);
    }
    if (m > n)
    {
        sum += m;
        SumFromMToN(m - 1, n, sum);
    }
    if (n == m)
    {
        sum += n;
        Console.WriteLine($"Cумма всех натуральных чисел в промежутке равна {sum}");
    }
}

//SumFromMToN(num1, num2, 0);

int SumFromMToNInt(int m, int n)
{
    if (m > n && m > 0)
    {
        return m + SumFromMToNInt(m - 1, n);
    }
    else if (n > m && n > 0)
    {
        return n + SumFromMToNInt(m, n - 1);
    }
    else if (m == n && m > 0) return m;
    else return 0;
}

int sum = SumFromMToNInt(num1, num2);
Console.WriteLine($"Cумма всех натуральных чисел в промежутке от {num1} до {num2} равна {sum}");
