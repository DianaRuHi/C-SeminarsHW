/* Напишите программу вычисления функции Аккермана с 
помощью рекурсии. Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29 */

int AccermanFunction(int arg1, int arg2)
{
    if (arg1 == 0) return arg2 + 1;
    else if (arg1 > 0 && arg2 == 0) return AccermanFunction(arg1 - 1, 1);
    else if (arg1 > 0 && arg2 > 0) return AccermanFunction(arg1 - 1, AccermanFunction(arg1, arg2 - 1));
    else return 0;
}

Console.WriteLine("Введите первый аргумент функции Аккермана:");
Console.Write("m = ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй аргумент функции Аккермана:");
Console.Write("n = ");
int num2 = Convert.ToInt32(Console.ReadLine());

int accermanFunction = AccermanFunction(num1, num2);
if (accermanFunction == 0) Console.WriteLine("Неверный ввод аргументов.");
else Console.WriteLine($"Функция Аккермана от {num1} и {num2} равна {accermanFunction}");
