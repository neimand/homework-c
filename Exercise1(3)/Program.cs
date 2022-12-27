/*Задача 1

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Проверка на пятизначность обязательна

14212 -> нет

12821 -> да

23432 -> да
*/

Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
string num = Convert.ToString(number);

if (num.Length == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"{number} - палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - не палиндром");
    }
}
else
{
    Console.WriteLine($"{number} - не является пятизначным");
}

