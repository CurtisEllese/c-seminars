// Написать программу, 
// 1. которая на вход принимает число и 
// 2. выдает  его квадрат.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
// int number1 = int.Parse(Console.ReadLine());

int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");
