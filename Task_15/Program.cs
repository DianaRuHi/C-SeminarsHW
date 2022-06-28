/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите номер дня недели.");
Console.Write("day = ");
int day = Convert.ToInt32(Console.ReadLine());

void Weekend(int dd)
{
    if (dd < 1 || dd > 7) Console.WriteLine("Ошибка ввода.");
    else if (dd >= 6) Console.WriteLine("Выходной день.");
    else Console.WriteLine("Будний день.");
}

Weekend(day);
