// Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortInDescendingElementsEachRows(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[j] = matrix[i, j];
        }
        SortMaxMin(arr);
        ReplacingValuesInRows(true, i, arr, matrix);
    }
}

void SortMaxMin(int[] array) //сортировка временного одномерного массива по убыванию
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
}

void ReplacingValuesInRows(bool fulfillmentCondition, int posRow, int[] array, int[,] matrix) //меняем значения в строке исходного массива на отсортированные значения
{
    for (int k = 0; k < array.Length; k++)
    {
        if (fulfillmentCondition) matrix[posRow, k] = array[k];
        else matrix[k, posRow] = array[k];
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
Console.WriteLine("Задан массив: ");
PrintMatrix(array2D);
Console.WriteLine("Новый массив: ");
SortInDescendingElementsEachRows(array2D);
PrintMatrix(array2D);