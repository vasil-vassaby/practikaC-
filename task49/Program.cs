﻿// Задайте двумерный массив. 
//найдите элементы у которых оба индекса четные и преобразовать эти числа в их квадрат

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //строка - matrix.GetLength(0) по условию 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //столбец - matrix.GetLength(1) по условию 4
        {
            matrix[i,j] = rnd.Next(min, max + 1);
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
        Console.Write($"{matrix[i,j], 5} ");
        }
        Console.WriteLine("|");
    }
}

// int[,] ReplaceMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 ==0) matrix[i,j] *= matrix[i,j];
//         }
//     }
//     return matrix;
// }

int[,] FindSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i,j] *= matrix[i,j];
        }
    }
    return matrix;
}

int[,] array2D = CreateMatrixRndInt(5, 5, -10, 15);
PrintMatrix(array2D);
Console.WriteLine();
int[,] result = FindSquare(array2D);
PrintMatrix(result);
