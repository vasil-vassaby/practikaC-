// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndInt(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(10, 100);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],3}({i},{j},{k})");
            }
        }
        Console.WriteLine();
    }
}

void CreateMatrixWithoutDuplicat(int[,,] matrix)
{
    int[] array = new int[matrix.Length];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(10, 100);
        int element = array[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (array[i] == array[j])
                {
                    array[i] = new Random().Next(10, 100);
                    j = 0;
                    element = array[i];
                }
                element = array[i];
            }
        }
    }
    int count = 0;
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int m = 0; m < matrix.GetLength(1); m++)
        {
            for (int n = 0; n < matrix.GetLength(2); n++)
            {
                matrix[k, m, n] = array[count];
                count++;
            }
        }
    }
}

int[,,] matrix = CreateMatrixRndInt(2, 2, 2);
CreateMatrixWithoutDuplicat(matrix);
PrintMatrix(matrix);