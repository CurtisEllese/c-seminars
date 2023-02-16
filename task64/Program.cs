// Задача 64: 
// 1. Задайте значение N. 
// 2. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1

int number = GetEnteredNumber("Введите натуральное число: ");

while (number < 1)
{
    number = GetEnteredNumber("Введите положительное, целое число верно: ");
}

PrintAllNaturalNums(number);

void PrintAllNaturalNums(int n)
{
    if (n == 0) return;
    Console.Write($"{n} ");
    PrintAllNaturalNums(n - 1);
}

int GetEnteredNumber(string text)
{
    Console.Write(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}