// Написать программу, которая
// 1. принимает на вход число (N) и 
// 2. выдает таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

Console.Write("Введите любое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 1)
{
    Console.WriteLine("Введите положительное, целое число верно!");
    number = Convert.ToInt32(Console.ReadLine());
}

    
GetSquareOfNumbers(number);

void GetSquareOfNumbers(int num)
{
    int count = 1;
    int squareNumber = 1;
    while (count <= num)
    {
        squareNumber = count * count;
        Console.WriteLine($"{count, 3}   {squareNumber, 3}");
        count++;
    }
}
