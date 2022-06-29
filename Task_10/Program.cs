/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Введите трехзначное число.");
Console.Write("n = ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < -999 || (num > -100 && num < 100) || num > 999) Console.WriteLine("Ошибка ввода.");
else 
{
    int digit2 = Math.Abs((num / 10) % 10);
    Console.WriteLine($"Вторая цифра это {digit2}");
}
