// Задача 58: 
// 1. Задайте две матрицы. 
// 2. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] firstMatrix = CreateMatrixRndInt(3, 3, 1, 10);
int[,] secondMatrix = CreateMatrixRndInt(2, 2, 1, 10);
Console.WriteLine("------Первая матрица------");
PrintMatrix(firstMatrix);
Console.WriteLine("------Вторая матрица------");
PrintMatrix(secondMatrix);

if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
{
    int[,] multiplyMatrix = MultiplyTwoMatrix(firstMatrix, secondMatrix);
    Console.WriteLine("------Произведение двух матриц------");
    PrintMatrix(multiplyMatrix);
}
else
{
    Console.WriteLine("Число столбцов в первой матрице должно равнятся числу строк во второй!");
}

int[,] MultiplyTwoMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                resMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resMatrix;
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