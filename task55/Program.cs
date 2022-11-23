﻿// Задайте двумерный массив. 
// Напишите программу, которая 
// заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для
// пользователя.

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

int[,] ReplaceRowsToColumns(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }
    }
    return newMatrix;
}

int[,] array2D = CreateMatrixRndInt(6, 5, 1, 9);
if (array2D.GetLength(0) == array2D.GetLength(1))
{
    PrintMatrix(array2D);
    Console.WriteLine();
    int[,] result = ReplaceRowsToColumns(array2D);
    PrintMatrix(result);
}
else Console.WriteLine("Ошибка. Невозможно заменить строки на столбцы ");

// int[,] ReplaceRowsToColumns(int[,] matrix)
// {
//     int temp = default;

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i; j < matrix.GetLength(1); j++)
//         {
//             temp = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temp;
//         }
//     }
// if (matrixRnd.GetLength(0) == matrixRnd.GetLength(1)) 
// {
//     int[,] replaceMatrix = ReplaceRowsToColumns(matrixRnd);
//     PrintMatrix(matrixRnd);
// }
// else Console.WriteLine("Вводите массив с равным количеством столбцов и строк");


//     return matrix;
// }
