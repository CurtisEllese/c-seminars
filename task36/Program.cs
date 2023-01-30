// Задача 36: 
// 1. Задайте одномерный массив, 
// 1(1). заполненный случайными числами. 
// 2. Найдите сумму элементов, 
// 2(1). стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = CreateArrayRndInt(4, -100, 100);
string strArray = ArrayToString(array);

int sumInOddPos = GetSumNumInOddPos(array);
Console.WriteLine($"{strArray} -> {sumInOddPos}");


int GetSumNumInOddPos(int[] arr)
{
    int result = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        result += arr[i];
    }
    return result;
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

string ArrayToString(int[] array)
{
    string result = String.Empty;

    for (int i = 0; i < array.Length - 1; i++)
    {
        result = result + ($"{array[i]}, ");
    }

    result = ($"[{result}{array[array.Length - 1]}]");
    return result;
}