// 1. Найти произведение пар чисел
// 1(1). в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и тд.
// 3. Результат записать в новом массиве.

// [1, 2, 3, 4, 5] -> [5, 8, 3]
// [6, 7, 3, 6] -> [36, 21]

int[] array = CreateArrayRndInt(4, 1, 10);
string strArray = ArrayToString(array);
int[] productNumArr = GetProductNumInArr(array);
string strProductNumArr = ArrayToString(productNumArr);

Console.WriteLine($"{strArray} -> {strProductNumArr}");


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

int[] GetProductNumInArr(int[] arr)
{
    int size = arr.Length % 2 != 0 ? arr.Length / 2 + 1 : arr.Length / 2;
    int[] resArray = new int[size];

    for (int i = 0; i < resArray.Length; i++)
    {
        resArray[i] = arr[i] * arr[arr.Length - i - 1];
    }

    if (arr.Length % 2 == 1) resArray[size - 1] = arr[arr.Length / 2];
    return resArray;
}
