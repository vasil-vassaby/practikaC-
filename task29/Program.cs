// Напишите программу, которая 
// задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]



int[] SetAnArray()
{
    int[] arr = new int[8];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 50);
    }
    return arr;
}

void PrintAnArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length-1; i++)
    {
        Console.Write(i != array.Length-1 ? $"{array[i]}," : $"{array[i]}");
    }
    Console.Write("]");
}

PrintAnArray(SetAnArray());