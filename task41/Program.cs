// Задача 41: 
// 1. Пользователь вводит с клавиатуры M чисел. 
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] array = Array.ConvertAll(GetArray("Введите числа через запятую: "), int.Parse);
string printArray = PrintArray(array);

int amountOfZeros = GetAmountZeros(array);

Console.WriteLine($"{printArray} -> {amountOfZeros}");

string[] GetArray(string text)
{
    Console.Write(text);
    string str = Console.ReadLine();
    string[] strArr = str.Split(",");
    return strArr;
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

int GetAmountZeros(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) result ++;
    }
    return result;
}