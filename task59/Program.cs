// Задача 59: 
// 1. Задайте двумерный массив из целых чисел. Напишите программу, 
// 2. которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
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

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
var minIndexMatrix = FindIndexMinInMatrix(array2D);

int[,] resultMatrix = DelIntersecRowCol(array2D, minIndexMatrix.row, minIndexMatrix.column);
PrintMatrix(resultMatrix);


int[,] DelIntersecRowCol(int[,] matrix, int iMin, int jMin)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;

    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (m == iMin) m++;
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (n == jMin) n++;
            result[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return result;
}

(int row, int column) FindIndexMinInMatrix(int[,] matrix)
{
    (int, int) minIndex = (0, 0);
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j]) 
            {
                min = matrix[i, j];
                minIndex = (i, j);
            }
        }
    }
    return minIndex;
}

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