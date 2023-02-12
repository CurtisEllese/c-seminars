// *Задача 60. 
// 1. Сформируйте трёхмерный массив 
// 2. из неповторяющихся двузначных чисел. 
// 3. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] array3D = FillArrayWithRndNumbers(2, 2, 2, 10, 99);
PrintArray3D(array3D);

int[,,] FillArrayWithRndNumbers(int rows, int col, int depth, int min, int max)
{
    int[,,] array3d = new int[rows, col, depth];
    Random rnd = new Random();
    int[] numbers = new int[max - min];
    int index = 0;

    for (int i = min; i < max + 1; i++)
    {
        if (index >= numbers.Length)
        {
            break;
        }
        numbers[index++] = i;
    }

    numbers = ShuffleArray(numbers, rnd);
    index = 0;

    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                array3d[i, j, k] = numbers[index++];
            }
        }
    }
    return array3d;
}

int[] ShuffleArray(int[] array, Random rnd)
{
    for (int i = 0; i < array.Length; i++)
    {
        int randomIndex = rnd.Next(i, array.Length);
        int temp = array[i];
        array[i] = array[randomIndex];
        array[randomIndex] = temp;
    }
    return array;
}

void PrintArray3D(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                Console.Write ($"{array3d[i, j, k], 5}({i}, {j}, {k})");
            }  
        }
        Console.WriteLine();
    }
}

