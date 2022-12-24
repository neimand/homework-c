/*Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int number1 = number % 10;
int number2 = (number / 10) % 10;
int number3 = (number / 100) % 10;
if(number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    if (number >= 100 && number < 999)
    {
        Console.WriteLine(number1);
    }
    if (number >= 1000 && number < 9999)
    {
        Console.WriteLine(number2);
    }
    if (number >= 10000 && number < 99999)
    {
        Console.WriteLine(number3);
    }
    if(number == 100000)
    {
        Console.WriteLine("0");
    }
}   