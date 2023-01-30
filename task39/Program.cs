// Написать программу, которая 
// 1. перевернет одномерный массив (последний элемент будет на первом месте, а первый - на последнем и тд.)

// [1, 2, 3, 4] -> [4, 3, 2, 1]
// [6, 7, 8, 6] -> [6, 8, 7, 6]

int[] array = CreateArrayRndInt(4, 1, 10);
PrintArray(array);
Console.Write(" -> ");
ReverseArray(array);
PrintArray(array);


void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
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



//2////////////////////////////////////////


// int[] array = CreateArrayRndInt(4, 1, 10);
// string strArray = ArrayToString(array);

// int[] reversedArray = ReverseArray(array);
// string strReversedArray = ArrayToString(reversedArray);

// Console.WriteLine($"{strArray} -> {strReversedArray}");

// int[] ReverseArray(int[] arr)
// {
//     int[] reversedArr = new int[arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         reversedArr[i] = arr[arr.Length - i - 1];
//     }
//     return reversedArr;
// }

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// string ArrayToString(int[] array)
// {
//     string result = String.Empty;

//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         result = result + ($"{array[i]}, ");
//     }

//     result = ($"[{result}{array[array.Length - 1]}]");
//     return result;
// }