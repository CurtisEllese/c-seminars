// Написать программу, которая
// 1. выводит случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.
// 78 => 8
// 12 => 2
// 85 => 8
int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10 - 99 => {number}");

int MaxDigit(int num)  //num -> number
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;

    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);

// int num = new Random().Next(10, 100);
// Console.WriteLine($"Случайное число из диапазона 10 - 99 => {num}");

// int firstDigit = num / 10;
// int secondDigit = num % 10;

// // if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
// // else Console.WriteLine($"Наибольшая цифра числа = {secondDigit}");

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.Write($"Наибольшая цифра числа = {maxDigit}"); 