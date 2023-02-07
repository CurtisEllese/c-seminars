// 1. Задайте двумерный массив.
// 2. Найти элементы, у которых оба индекса четные
// 3. и заменить их на их квадраты

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();

int[,] squareMatrix = SquareEvenMatrix(array2D);
PrintMatrix(squareMatrix);
Console.WriteLine();

PrintMatrix(array2D);


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

int[,] SquareEvenMatrix(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i += 2)
    {
        for (int j = 0; j < result.GetLength(1); j += 2)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                result[i, j] = matrix[i, j] * matrix[i, j];
            }
            else
            {
                result[i, j] = matrix[i, j];
            
            }
        }
    }
    return result;
}