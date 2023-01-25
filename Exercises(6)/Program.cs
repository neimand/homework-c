// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

Console.Clear();

Console.WriteLine("Введите числа через пробел: ");
string numS = Console.ReadLine()!;
int[] numS_array = ConvertToInt(numS);
NumsOverZero(numS_array);

int[] ConvertToInt(string elements)
{
    string[] string_nums = elements.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] int_nums = new int[string_nums.Length];
    for (int i = 0; i < string_nums.Length; i++)
    {
        int_nums[i] = Convert.ToInt32(string_nums[i]);
    }
    return int_nums;
}

void NumsOverZero(int[] numbers)
{
    int count = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество чисел больше нуля -> {count}");
}


// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов 
// (не менее 6) в промежутке от 0 до 100, а на выходе выводит этот же массив, 
// но отсортированный по возрастанию(от меньшего числа к большему).

Console.Clear();

int[] array = GetArray(10, 0, 100);

int[] SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
        if(array[j] < array[minPosition])
        {
            minPosition = j;
        } 
        }
        int temprorary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temprorary;
    }
    return array;
}

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

Console.WriteLine($"[{String.Join(",", array)}] -> [{String.Join(",", SelectionSort(array))}]"); 


