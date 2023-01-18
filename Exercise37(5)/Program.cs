/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6] -> 36 21
*/

Console.Clear();

int[] array = GetArray(4, 1, 10);
int[] array2 = new int [2];

int[] CompElements(int[] array2)
{
    for(int i = 0; i < (array.Length/2); i++)
    {
        array2[i] = array[i] * array[array.Length - i - 1];
    }
    return array2;
}

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

Console.WriteLine($"[{String.Join(",", array)}] -> [{String.Join(",", CompElements(array2))}]");
