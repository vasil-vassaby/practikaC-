// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine("|");
    }
}

int[] SumElementRows(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {

        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            array[j] += matrix[j, i];
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Cумма строки {i + 1} = {array[i]} ");
    }
}

int NumberMinSumRow(int[] array)
{
    int minSumElement = array[0];
    int minNumberRow = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minSumElement)
        {
            minSumElement = array[i];
            minNumberRow = i + 1;
        }
    }
    return minNumberRow;
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int[] arr = SumElementRows(array2D);
PrintArray(arr);
Console.WriteLine();
int minNumber = NumberMinSumRow(arr);
Console.WriteLine($"Cтрока с наименьшей суммой элементов: {minNumber} строка");