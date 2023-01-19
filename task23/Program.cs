// Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите любое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 1)
{
    Console.WriteLine("Введите положительное, целое число верно!");
    number = Convert.ToInt32(Console.ReadLine());
}

    
Console.WriteLine($"{number} ->");
GetCubeOfNumbers(number);

void GetCubeOfNumbers(int num)
{
    int count = 1;
    int cubeNumber = 1;
    while (count <= num)
    {
        cubeNumber = count * count * count;
        Console.WriteLine($"{count, 3} | {cubeNumber, 3}");
        count++;
    }
}