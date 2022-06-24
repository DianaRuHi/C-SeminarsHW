/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите число.");
Console.Write("num = ");
int num = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(num % 2) == 0)
{
    Console.Write("Да, число четное.");
}
else
{
    Console.Write("Нет, число не является четным.");
}