// 1. Задать одномерный массив из 123 случайных чисел.
// 2. Найти кол-во элементов массива, значения которых лежат в отрезке (10,99).

int[] array = CreateArrayRndInt(5, 0, 200);
PrintArray(array);
int amountOfNumbers = GetAmountOfNumbers(array, 10, 99);

Console.WriteLine($" -> {amountOfNumbers}");

int GetAmountOfNumbers(int[] arr, int rangeFrom, int rangeTo)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= rangeFrom && arr[i] <= rangeTo) result ++;
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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length -1) Console.Write (arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}
