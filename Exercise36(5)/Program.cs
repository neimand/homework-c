/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных индексах.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
Console.Clear();

int[] array = GetArray(4, -10, 99);
int sum = 0;

int SumUneven(int sum)
{
    for(int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

Console.WriteLine($"[{String.Join(",", array)}] -> {SumUneven(sum)}");

