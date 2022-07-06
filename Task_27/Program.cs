/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Введите число.");
Console.Write("n = ");
int num = int.Parse(Console.ReadLine());

int SumNum(int n)
{
    int result = 0;
    int nNew = Math.Abs(n);
    while (nNew > 0)
    {
        result = result + nNew % 10;
        nNew = nNew / 10;
    }
    return result;
}

Console.WriteLine($"Суммна цифр числа {num}  равна {SumNum(num)}");
