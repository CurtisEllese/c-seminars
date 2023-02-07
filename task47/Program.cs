// Задача 47. 
// 1. Задайте двумерный массив размером m×n, 
// 2. заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5   7      -2    -0,2
// 1     -3,3    8    -9,9
// 8     7,8    -7,1   9

double[,] array2D = CreateMatrixRndDouble(3, 4, -10, 100);
PrintDoubleMatrix(array2D);


double[,] CreateMatrixRndDouble(int rows, int col, int min, int max)
{
    double[,] matrix = new double[rows, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(min, max + 1) / 10.0;
            }
    }
    return matrix;
}

void PrintDoubleMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) -1) Console.Write ($"{matrix[i, j], 6},");
            else Console.Write($"{matrix[i, j], 6}  ");   
        }
        Console.WriteLine("]");
    }
}