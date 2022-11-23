// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

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

int[] IndexMinElementMatrix(int[,] matrix)
{
    int min = matrix[0, 0];
    int[] minIndex = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                minIndex[0] = i;
                minIndex[1] = j;
            }
        }
    }
    return minIndex;
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


int[,] CreateMatrixMax(int[,] matrix, int m, int n)
{
    int[,] matrixMax = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    int countHor=0;
    int countVer=0;
    for (int i = 0; i < matrixMax.GetLength(0); i++)
    {
        if (countHor==m) countHor ++;
        for (int j = 0; j < matrixMax.GetLength(1); j++)
        {
            if (countVer==n) countVer ++;
            {
                matrixMax[i, j] = matrix[countHor, countVer]; 
            }
            countVer ++;               
        }
        countVer = 0; 
        countHor ++;
    } 
    return matrixMax;
}


int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int[] minIndex = IndexMinElementMatrix(array2D);
PrintArray(minIndex);
int[,] newMatrix = NewMatrix(array2D, minIndex);
PrintMatrix(newMatrix);

int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // 2
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1); // 2 - 3
            }
            
        }
    }
    return matrix;
}
