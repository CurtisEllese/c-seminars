// Написать программу, которая 
// 1. принимает на вход трехзначное число и 
// 2. на выходе показывает последнюю цифру этого числа.

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 999 && num >= 100)
{
    int lastNum = num % 10;
    Console.Write($"Последняя цифра числа {num} - {lastNum}");
}
else
{
    Console.Write("Вы ввели некорректное число!");
};
