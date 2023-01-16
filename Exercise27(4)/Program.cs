/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
Console.Clear();

Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр {n} равна {GetSum(n)}");

int GetSum(int n)
{
    int sum = 0;
    while (n > 0)
    {
        int num = n % 10;
        n = n / 10;
        sum = sum + num;
    }
    return sum;
}