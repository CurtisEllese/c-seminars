// Задача 67: 
// 1. Напишите программу, которая будет принимать на вход число и
// 2. возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int number = GetEnteredNum("Введите число: ");
int sumOfDigits = GetSumOfDigits(number);
Console.WriteLine($"{number} -> {sumOfDigits}");

int GetSumOfDigits(int num)
{
    if (num == 0) return 0;
    else return GetSumOfDigits(num / 10) + num % 10;
}

int GetEnteredNum(string text)
{
    Console.Write(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}