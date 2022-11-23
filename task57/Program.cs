// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) //создание двумерного массива рандомно
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

void PrintMatrix(int[,] matrix) //печать двумерного массива
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

int[] MatrixToArray(int[,] matrix) //перевод двумерного массива в одномерный массив
{
    int[] newArray = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newArray[k] = matrix[i, j];
            k++;
        }
    }
    return newArray;
}

void PrintArray(int[] array) //печать одномерного массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(i < array.Length - 1 ? $"{array[i]}," : $"{array[i]}");
    }
    Console.WriteLine("]");
}

void Dictionary(int[] array)
{
    int elem = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (elem == array[i]) count++;
        else
        {
            Console.WriteLine($"Элемент {elem} встречается {count} раз");
            elem = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"Элемент {elem} встречается {count} раз");
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int[] result = MatrixToArray(array2D);
Array.Sort(result);
PrintArray(result);
Console.WriteLine();
Dictionary(result);

// Console.Write("Введите количество строк двумерного массива : ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов двумерного массива : ");
// int n = Convert.ToInt32(Console.ReadLine());


// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j],5}");
//             if (j < matrix.GetLength(1) - 1) Console.Write(" |");
//         }
//         Console.WriteLine(" ]");
//     }
// }
// void CountElements(int[] array)
// {
//     int elem = array[0];
//     int count = 1;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (elem == array[i]) count++;
//         else
//         {
//             Console.WriteLine($"Элементов {elem} => {count}");
//             elem = array[i];
//             count = 1;
//         }
//     }
//     Console.WriteLine($"Элементов {elem} => {count}");
// }

// int[,] newMatrixRndInt = CreateMatrixRndInt(m, n, 1, 10);
// Console.WriteLine("массив заполненный случайными целыми числами");
// PrintMatrix(newMatrixRndInt);
// Console.WriteLine();
// int[] newArray = NewArray(newMatrixRndInt);
// Array.Sort(newArray);
// Console.WriteLine("сортированный одномерный массив");
// PrintArray(newArray);
// Console.WriteLine();
// CountElements(newArray);
