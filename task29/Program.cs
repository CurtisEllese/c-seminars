// Задача 29: Напишите программу, которая 
// 1. задаёт массив из 8 элементов и 
// 2. выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] arr = CreateArray(8);
string printedArray = PrintArray(arr);
Console.Write($"{printedArray} -> [{printedArray}]");

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

string PrintArray(int[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length - 1; i++)
    {
        result = result + ($"{array[i]}, ");
    }
    result = result + ($"{array[array.Length - 1]}");
    return result;
}