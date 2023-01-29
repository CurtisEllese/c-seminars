// 1. Задать массив.
// 2. Написать программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] array = CreateArrayRndInt(5, 0, 10);
string printArray = PrintArray(array);

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckNumInArr(array, number))
    {
    Console.WriteLine($"{number}; массив {printArray} -> да");
}
else 
{
    Console.WriteLine($"{number}; массив {printArray} -> нет");
}

bool CheckNumInArr(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
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

string PrintArray(int[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length - 1; i++)
    {
        result = result + ($"{array[i]}, ");
    }
    result = ($"[{result}{array[array.Length - 1]}]");
    return result;
}