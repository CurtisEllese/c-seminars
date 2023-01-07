// Написать программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным
// 3. если вводит неверное число, указать на ошибку.

// 6 -да 
// 7  - да
// 1 - нет

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool IsWeekend(int num)
{
    return num == 6 || num == 7;
}

if (number >= 1 && number <= 7)
{
    if (IsWeekend(number))
    {
    Console.WriteLine($"{number} -> да");
    }
    else
    {
    Console.WriteLine($"{number} -> нет");
    }
}
else 
{
    Console.WriteLine("Введите корректное число");
}
