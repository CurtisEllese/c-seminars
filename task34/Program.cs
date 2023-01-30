// Задача 34: 
// 1. Задайте массив 
// 1(1). заполненный случайными положительными трёхзначными числами. 
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = CreateArrayRndInt(5, 100, 999);
string strArray = ArrayToString(array);

int amountEvenNum = GetAmountEvenNum(array);

Console.WriteLine($"{strArray} -> {amountEvenNum}");

int GetAmountEvenNum(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) result++;
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