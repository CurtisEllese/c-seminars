// 1. Задать двумерный массив размера м на н,
// 2. Каждый элемент в массиве находится по формуле Амн = м+н.
// 3. вывести полученный массив на экран.

int[,] array2D = CreateMatrixInt(3, 4);

PrintMatrix(array2D);

int[,] CreateMatrixInt(int rows, int col)
{
    int[,] matrix = new int[rows, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = i + j;
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