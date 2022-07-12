/* Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double[] DotCrossing(double kk1, double bb1, double kk2, double bb2)
{
    double[] arr = new double[2];
    arr[0] = (bb2 - bb1) / (kk1 - kk2);
    arr[1] = bb1 + arr[0] * kk1;
    return arr;
}

Console.WriteLine("Задайте коэффициенты уравнения для первой прямой:");
Console.Write("k1 = ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("b1 = ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Задайте коэффициенты уравнения для второй прямой:");
Console.Write("k2 = ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("b2 = ");
double b2 = double.Parse(Console.ReadLine());

if (k1 != k2)
{
    double[] dot = DotCrossing(k1, b1, k2, b2);
    Console.WriteLine($"Точка пересечения линий ({dot[0]}, {dot[1]})");
}
else Console.WriteLine("Прямые не пересекаются");
