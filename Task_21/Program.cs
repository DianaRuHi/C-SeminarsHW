/* Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Hello, World!");

Console.WriteLine("Введите координаты точки A:");
Console.Write("x = ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write("x = ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int bz = Convert.ToInt32(Console.ReadLine());


double anser = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));

Console.WriteLine($"Расстояние между точками равно {Math.Round(anser, 2)}");