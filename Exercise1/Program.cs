﻿Console.Clear();
/*Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

int max = a;
int min = b;

if(b > max)
{
    max = b;
    Console.Write("max = ");
    Console.WriteLine(max);
} 
if(a < min)
{
    min = a;
    Console.Write("min = ");
    Console.WriteLine(min);
}
