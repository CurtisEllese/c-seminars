// Задача 38: 
// 1. Задайте массив 
// 1(!). вещественных чисел.
// 1(!!). Округлить значения после запятой до первого знака.
// 2. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] arrayDouble = CreateArrayRndDouble(5, 1, 100);
string strArrayDouble = DoubleArrayToString(arrayDouble);

double min = GetMinNumArrDouble(arrayDouble);
double max = GetMaxNumArrDouble(arrayDouble);
double minMaxDiff = max - min;

Console.WriteLine($"{strArrayDouble} -> {minMaxDiff}");

double GetMinNumArrDouble(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double GetMaxNumArrDouble(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(arr[i], 1);
    }
    return arr;
}

string DoubleArrayToString(double[] array)
{
    string result = String.Empty;

    for (int i = 0; i < array.Length - 1; i++)
    {
        result = result + ($"{array[i]}, ");
    }

    result = ($"[{result}{array[array.Length - 1]}]");
    return result;
}