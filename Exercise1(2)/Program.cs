/*
Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
Обязательна проверка на ввод чисел больше/меньше 3-х знаков

456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int number2 = (( number % 100) / 10);

if (number <= 99 || number > 1000 )
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(number2);
}




