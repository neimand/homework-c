/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
Console.Clear();

Console.Write("Введи первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введи второе число: ");
int b = int.Parse(Console.ReadLine()!);

int ToDegree(int a, int b)
{
    int step = a;
    for (int i = 1; i < b; i++)
    {
        step = step * a;
    }
    return step;
}
Console.WriteLine("A в степени B равно: " + ToDegree(a, b));

