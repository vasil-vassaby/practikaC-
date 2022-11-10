// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

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

int[] GetSumPositiveNegativeElem(int[] array)
{
    int sumPositive = default;
    int sumNegative = default;

    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] > 0) sumPositive += array[i];
       else sumNegative += array[i];
    }
    return new int[] { sumPositive, sumNegative };// массив из двух эл-тов - 0, 1, поэтому в выводе указываем индекс мак=0, и мин=1
}


int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] getSumPositiveNegativeElem = GetSumPositiveNegativeElem (arr);
Console.WriteLine($"Сумма положительных элементов {getSumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов {getSumPositiveNegativeElem[1]}");