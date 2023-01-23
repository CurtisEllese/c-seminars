// Написать программу, которая
// 1. принимает на вход число N и 
// 2. выдает произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);

if (number >= 0) Console.WriteLine($"{number}! = {factorial}");
else Console.WriteLine("Введите корректное число!");

int Factorial(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result *= i;
    }
    return result;
}