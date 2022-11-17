// создать двумерный массив 3, 4

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

int[,] array2D = CreateMatrixRndInt(3, 4, -100, 150);
PrintMatrix(array2D);