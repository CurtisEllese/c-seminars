// *Задача 62. Напишите программу, которая 
// 1. заполнит спирально 
// 2. массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04        01 02 03 04       0,0  0,1  0,2  0,3      0,0  0,1  0,2  0,3
// 05 06 07 08        12 13 14 05       1,0  1,1  1,2  1,3      2,3  3,0  3,1  1,0
// 09 10 11 12        11 16 15 06       2,0  2,1  2,2  2,3      2,2  3,3  3,2  1,1
// 13 14 15 16        10 09 08 07       3,0  3,1  3,2  3,3      2,1  2,0  1,3  1,2

int[,] array2d = CreateSpiralMatrix(4, 4);
PrintMatrix(array2d);

int[,] CreateSpiralMatrix(int rows, int col)
{
    int[,] matrix = new int[rows, col];
    int num = 1;
    int k = 0;
    int l = 0; 
    
    while (k < rows && l < col) 
    {
        for (int i = l; i < col; i++) 
        {
            matrix[k, i] = num++;
        }
        k++;

        for (int i = k; i < rows; i++)
        {
            matrix[i, col - 1] = num++;
        }
        col--;

        if (k < rows) 
        {
            for (int i = col - 1; i >= l; i--)
            {
                matrix[rows - 1, i] = num++;
            }
            rows--;
        }

        if (l < col)
        {
            for (int i = rows - 1; i >= k; i--)
            {
                matrix[i, l] = num++;
            }
            l++;
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