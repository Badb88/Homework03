/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координаты точки А");
Console.WriteLine("Введите координату X точки А:");
int XA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А:");
int YA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А:");
int ZA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.WriteLine("Введите координату X точки B:");
int XB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B:");
int YB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B:");
int ZB = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((XA - XB) * (XA - XB) + (YA - YB) * (YA - YB) + (ZA - ZB) * (ZA - ZB));

Console.WriteLine("Расстояние между точками А и В равняется: " + Math.Round(result, 2));