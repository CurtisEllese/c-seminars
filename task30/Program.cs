// Написать программу, которая
// 1. выводит массив из 8 элементов,
// 2. заполненный нулями и единицами в случайном порядке


int[] arr = CreateArray(8);
PrintArray(arr);

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}