// Написать программу замены элементов массива:
// 1. положительные элементы заменить на соответствующие отрицательные и наоборот:
// [-4, 8, -8, 2] -> [4, -8, 8, 2]

int[] array = CreateArrayRndInt(4, -10, 10);
PrintArray(array);

int[] reverseNumbersArr= ReverseElementsArr(array);
PrintArray(reverseNumbersArr);


int[] ReverseElementsArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
    return arr;
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
    Console.WriteLine("]");
}