// 1. Задать двумерный массив.
// 2. Найти сумму элементов, находящихся на главной диагонали (с индексами (0, 0) (1,1) и тд)

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);

int sumDiagonalMatrix = FindSumDiagonalMatrix(array2D);
Console.WriteLine($"Сумма элементов главной диагонали = {sumDiagonalMatrix}");

int[,] CreateMatrixRndInt(int rows, int col, int min, int max)
{
    int[,] matrix = new int[rows, col];
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
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) -1) Console.Write ($"{matrix[i, j], 5},");
            else Console.Write($"{matrix[i, j], 5}  ");   
        }
        Console.WriteLine("]");
    }
}

int FindSumDiagonalMatrix(int[,] matrix)
{
    int result = 0;
    int i = 0;
    while (i < matrix.GetLength(0) && i < matrix.GetLength(1))
    {
        result += matrix[i, i];
        i++;
    }
    return result;
}