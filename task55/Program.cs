// Задача 55: 
// 1. Задайте двумерный массив. 
// 2. Напишите программу,которая заменяет строки на столбцы в новом массиве. 
// 3. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] array2D = CreateMatrixRndInt(5, 5, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();

if (array2D.GetLength(0) == array2D.GetLength(1))
{
    int[,] changedMatrix = ChangeRowsToCol(array2D);
    PrintMatrix(changedMatrix);
}
else
{
    Console.WriteLine("Задайте квадратную матрицу");
}


int[,] ChangeRowsToCol(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i, j] = matrix[j, i];
        }
    }
    return result;
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