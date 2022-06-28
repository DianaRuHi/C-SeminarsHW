/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите число.");
Console.Write("n = ");
int num = Convert.ToInt32(Console.ReadLine());

int Digit3(int number)
{
    while (number < -999 || number > 999)
    {
        number = number / 10;
    }
    return Math.Abs(number % 10);
}

if (num > -100 && num < 100) Console.WriteLine("Третьей цифры нет.");
else Console.WriteLine($"Третья цифра это {Digit3(num)}");
