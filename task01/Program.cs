// Написать программу, которая 
// 1. на вход принимает 2 числа и 
// 2. проверяет, является ли первое число квадратом второго.

Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a / b == b)
{
    Console.WriteLine($"Число {a} является квадратом числа {b}");
}
else
{
    Console.WriteLine($"Число {a} не является квадратом числа {b}");
};