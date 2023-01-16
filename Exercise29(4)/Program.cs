/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)*/
Console.Clear();

int[] GetArray(int size)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++){
        myArray[i] = new Random().Next(100);
    }
    return myArray;
}

int[] myArray = GetArray(8);
Console.WriteLine($"[{String.Join(',', myArray)}]");
