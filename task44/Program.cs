﻿// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] Fibonacсi(int num)
{
    int[] array = new int[num];
    array[1]= 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i]=array[i-1]+array[i-2];
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(i < array.Length - 1 ? $"{array[i]}," : $"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] result = Fibonacсi(number);
PrintArray(result);