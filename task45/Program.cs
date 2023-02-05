// Написать программу, которая
// 1. будет создавать копию заданного массива, с помощью поэлементного копирования.

int[] array = new int[10];
FillArray(array);
string strArray = PrintArray(array);

int[] copyArray = CopyArray(array);
string strCopyArray = PrintArray(copyArray);

Console.WriteLine($"Массив - {strArray}, его копия - {strCopyArray}");


int[] CopyArray(int[] arr)
{
    int[] copyArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArr[i] = arr[i];
    }
    return copyArr;
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
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