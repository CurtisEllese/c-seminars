// Задача 50. 
// 1. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// 2. возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
FindIndex(array2D);


void FindIndex(int[,] matrix)
{
    int rowIndx = GetEnterNum("Введите индекс строки: ");
    int columnIndx = GetEnterNum("Введите индекс столбца: ");
    
    if (rowIndx < 0 || columnIndx < 0)
    {
        Console.WriteLine($"{rowIndx}, {columnIndx} -> Такого элемента в массиве нет");
    }
    else if (rowIndx <= matrix.GetLength(0) && columnIndx <= matrix.GetLength(1))
    {
        Console.WriteLine($"{rowIndx}, {columnIndx} -> {matrix[rowIndx, columnIndx]}");
    }
}

int GetEnterNum(string text)
{
    Console.Write(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
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