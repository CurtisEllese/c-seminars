// Задача 2: Напишите программу, которая 
// 1. на вход принимает два числа и 
// 2. выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7

Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.Write($"Большее число {a}, а меньшее число {b}");
}
else if (a < b)
{
    Console.Write($"Большее число {b}, а меньшее число {a}");
}
else if (a == b)
{
    Console.Write($"Число {b} и {a} равны");
};
