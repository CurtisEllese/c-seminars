// 1. Задайте двумерный массив
// 2. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
ChangeFirstLastRow(matrix);
PrintMatrix(matrix);


void ChangeFirstLastRow(int[,] matr)
{
    int firstRow = 0;
    int lastRow = matr.GetLength(0) - 1;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        int temp = matr[firstRow, i];
        matr[firstRow, i] = matr[lastRow, i];
        matr[lastRow, i] = temp;
    } 
}


// void ChangeFirstLastRow(int[,] matr)
// {
//     int rows = matr.GetLength(0);
//     int columns = matr.GetLength(1);
//     int[,] temp = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             if (i == 0)
//             {
//                 temp[i, j] = matr[i, j];
//                 matr[i, j] = matr[rows - 1, j];
//                 matr[rows - 1, j] = temp[i, j];
//             }
//         } 
//     }
// }

int[,] CreateMatrixRndInt(int rows, int col, int min, int max)
{
    int[,] matr = new int[rows, col];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = rnd.Next(min, max + 1);
            }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(j < matr.GetLength(1) -1) Console.Write ($"{matr[i, j], 5},");
            else Console.Write($"{matr[i, j], 5}  ");   
        }
        Console.WriteLine("]");
    }
}