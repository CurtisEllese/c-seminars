﻿// Задача 52. 
// 1. Задайте двумерный массив из целых чисел. 
// 2. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);

string averageColumnArr = GetAverageColumn(array2D);
Console.WriteLine($"Среднее арифметическое каждого столбца: {averageColumnArr}");


string GetAverageColumn(int[,] matrix)
{
    string result = String.Empty;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double temp = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            temp += matrix[i, j];
        }
        temp = Math.Round(temp / matrix.GetLength(0), 1);
        result += temp + "; ";
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
