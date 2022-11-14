﻿// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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

int SumOddElementsArray(int[] array)
{
    int sum = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum+=array[i];
    }
    return sum;
}

Console.Write("Массив заполненный случайными числами:");
int[] arr = CreateArrayRndInt(4, -90, 90);
PrintArray(arr);

int sumOddElementsArray = SumOddElementsArray(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sumOddElementsArray}");