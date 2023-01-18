﻿/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int[] array = GetArray(4, 100, 999);
Console.WriteLine($"[{String.Join(",", array)}] -> {CountElement(array)}");

int CountElement(int[] array)
{
    int count = 0;
    foreach(int el in array)
    {
        if(el % 2 == 0)
        {
            count++;
        }
    } 
    return count;
}

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}




