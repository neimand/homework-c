/* Задача 64: Выполнить с помощью рекурсии.
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"N = {N} -> {PrintNatNumbers(N, 1)}");

// -----------Методы------------

string PrintNatNumbers(int start, int end)
{
    if (start == end) return end.ToString();
    return (start + "," + " " + PrintNatNumbers(start - 1, end));
}



/* Задача 66: Выполнить с помощью рекурсии.
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"M = {M}; N = {N} -> {SumNumbers(M, N)}");

// -----------Методы------------

int SumNumbers(int M, int N)
{                         
     if (M == 0) return (N * (N + 1)) / 2;            
    else if (N == 0) return (M * (M + 1)) / 2;       
    else if (M == N) return M; 
    if (M < N) return N + SumNumbers(M, N - 1); 
    else return N + SumNumbers(M, N + 1);
}





/* Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"M = {M}; N = {N} -> {Akkerman(M, N)}");

// -----------Методы------------

int Akkerman(int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0) return Akkerman(M - 1, 1);
    else return Akkerman(M - 1, Akkerman(M, N - 1));
}