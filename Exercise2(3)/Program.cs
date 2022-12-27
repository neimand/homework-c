/*Задача 2

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

Console.WriteLine("Введите координату Xa: ");
int xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Ya: ");
int ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Za: ");
int za = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Xb: ");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Yb: ");
int yb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Zb: ");
int zb = int.Parse(Console.ReadLine()!);

double res = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
Console.WriteLine($"Расстояние между точками: {res:f2}");
