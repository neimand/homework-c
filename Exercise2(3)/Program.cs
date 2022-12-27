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








// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*Console.Write("Введи Х: ");
int x = int.Parse(Console.ReadLine()!);

Console.Write("Введи Y: ");
int y = int.Parse(Console.ReadLine()!);

if(x > 0 && y > 0)
{
    Console.WriteLine("Это первая четверть");
}
if(x < 0 && y > 0)
{
    Console.WriteLine("Это вторая четверть");
}
if(x < 0 && y < 0)
{
    Console.WriteLine("Это третья четверть");
}
if(x > 0 && y < 0)
{
    Console.WriteLine("Это четвертая четверть");
}
*/

// задача №2

/*Console.WriteLine("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine()!);

switch(num)
{
    case 1: {
        Console.WriteLine("x > 0 and y > 0");
        break;
    }
    case 2: {
        Console.WriteLine("x < 0 and y > 0");
        break;
    }
        case 3: {
        Console.WriteLine("x < 0 and y < 0");
        break;
    }
        case 4: {
        Console.WriteLine("x > 0 and y < 0");
        break;
    }
    default:
    {
        Console.WriteLine("Ошибка");
        break;
    }
}*/

// задача №3

/*Console.WriteLine("Введите координату х1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату х2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y2: ");
int y2 = int.Parse(Console.ReadLine()!);

double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Расстояние между точками: {res:f2}");*/

// задача №4

/*Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

for(int i = 1; i <= n; i++ ){
    Console.WriteLine(i * i);
}
*/