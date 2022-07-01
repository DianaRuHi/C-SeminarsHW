/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите число:");
Console.Write("n = ");
int num = Convert.ToInt32(Console.ReadLine());

List<int> ListNum(int n)
{
    List<int> number = new List<int>();
    number.Insert(0, n % 10);
    n = n / 10;
    while (n != 0)
    {
        number.Insert(0, n % 10);
        n = n / 10;
    }
    return number;
}

List<int> numList = ListNum(num);
int paper = 0;

for (int i = 0; i < numList.Count / 2; i++)
{
    if (numList[i] != numList[numList.Count - i - 1])
    {
        paper = 1;
        break;
    }
}

if (paper == 0) Console.WriteLine("Да, число является полиндромом.");
else Console.WriteLine("Нет, число не является полиндромом.");
