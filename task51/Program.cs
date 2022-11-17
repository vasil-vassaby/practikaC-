// Задайте двумерный массив. Найдите сумму элементов по диагонали массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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

// int SumDiagonalElementMatrix(int[,] matrix)
// {
//     int sum = default;
//     for (int i = 0; i < matrix.GetLength(0); i++) 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i==j) sum += matrix[i,j];
//         } 
//     }
//     return sum;
// }

int SumDiagonalElementMatrix(int[,] matrix)
{
    int sum = 0;
    int minLength = matrix.GetLength(0);
    if (matrix.GetLength(1) > matrix.GetLength(0)) minLength = matrix.GetLength(1);
    for (int i = 0; i < minLength; i++) sum += matrix[i,i];
    return sum;
} 
int[,] array2D = CreateMatrixRndInt(3, 4, -15, 15);
PrintMatrix(array2D);
int sumDiagonalElementMatrix = SumDiagonalElementMatrix(array2D);
Console.WriteLine($"Сумма элементов по диагонали равна {sumDiagonalElementMatrix}");