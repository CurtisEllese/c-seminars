// 1. Принять на вход число N,
// 2. Вывести первые N чисел Фибоначчи.
// 2(!). НЕ использовать рекурсию
// 2(!!). Первые два числа Фибоначчи: 0 и 1.

// N = 5 -> 0 1 1 2 3
// N = 3 -> 0 1 1
// N = 7 -> 0 1 1 2 3 5 8

int number = GetEnterNum("Введите натуральное число: ");

int[] fiboArray = GetFiboNum(number);
string stringArray = PrintArray(fiboArray);

Console.WriteLine($"N = {number} -> {stringArray}");

int[] GetFiboNum(int num)
{
    int[] arr = new int[num];
    arr[0] = 0;
    arr[1] = 1;
    
    for (int i = 2; i < num; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

int GetEnterNum(string text)
{
    Console.Write(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
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