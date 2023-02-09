// Задача 56: 
// 1. Задайте прямоугольный двумерный массив. 
// 2. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array2D = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(array2D);

int smallSumRow = FindSmallSumRow(array2D);

Console.WriteLine($"Индекс строки с наименьшей суммой элементов - {smallSumRow}");

int FindSmallSumRow(int[,] matrix)
{
    int result = 0;
    int[] row = new int[matrix.GetLength(1)];
    int min = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            row[j] = matrix[i, j];
        }
        int sum = SumOfRow(row);

        if (min > sum)
        {
            min = sum;
            result = i;
        }
        else if (i == 0)
        {
            min = sum;
        }
    }
    return result;
}

int SumOfRow(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        result += arr[i];
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