/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Введите натуральное число.");
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1) Console.WriteLine("Ошибка ввода");
else
{
    int index = 1;
    while (index <= n)
    {
        Console.WriteLine($"| Куб числа {index,4} | {Math.Pow(index, 3),5} | ");
        index++;
    }
}
