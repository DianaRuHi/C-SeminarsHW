/*  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.WriteLine("Введите число А.");
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B.");
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());

double Po(int num1, int num2)
{
    double result = 1;
    if (num2 > 0)
    {
        for (int i = 1; i <= num2; i++)
        {
            result *= num1;
        }
    }
    else if (num2 < 0)
    {
        for (int i = -1; i >= num2; i--)
        {
            result /= num1;
        }
    }
    else if (num2 == 0 && num1 < 0) result = -1;
    return result;
}

Console.WriteLine($"Число {a} в степени {b} = {Po(a, b)}");
