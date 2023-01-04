// Задача 8: Напишите программу, которая 
// 1. на вход принимает число (N), а 
// 2. на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 0;

while (count < num - 1)
{
    count += 2;
    Console.Write($"{count} ");
};
