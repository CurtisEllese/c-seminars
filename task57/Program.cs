//  Задача 57: 
// 1. Составить частотный словарь элементов
// двумерного массива. 
// 2. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);

int[] array = ConvertMatrixToArr(array2D);
Array.Sort(array);
PrintArray(array);

int[,] dictionaryMatrix = CreateDictionaryFromArr(array);
PrintMatrix(dictionaryMatrix);

int[,] CreateDictionaryFromArr(int[] arr)
{
    int[,] result = new int[arr.Length, 2];
    int currValue = arr[0];
    result[0, 0] = currValue;
    result[0, 1] = 1;
    int cnt = 0; 
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == currValue)
        {
            result[cnt, 1]++;
        }
        else
        {
            cnt++;
            result[cnt, 0] = arr[i];
            result[cnt, 1]++;
            currValue = arr[i];
        }
    }
    return result;
}

int[] ConvertMatrixToArr(int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int temp  = arr.Length;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[temp - 1] = matrix[i, j];
            temp--;
        }
    }
   return arr;
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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length -1) Console.Write (arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}