// Напишите программу 
// замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] ReplacePositiveNegativeRndInt(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = array[i]*-1;
    }
    return array;
}


int[] arr = CreateArrayRndInt(4, -9, 9);
PrintArray(arr);
int[] replacePositiveNegativeRndInt = ReplacePositiveNegativeRndInt(arr);
PrintArray(replacePositiveNegativeRndInt);