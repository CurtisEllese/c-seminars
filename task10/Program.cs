// Написать программу, которая 
// 1. принимает на вход трехзначное число и 
// 2. на выходе показывает вторую цифру этого числа.

// 465 - 6
// 782 - 8
// 918 - 1

Console.WriteLine("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int FindSecondNum(int num)
{
    int secondDigit = num / 10 % 10;
    return secondDigit;
}

if (100 <= number && number <= 999)
{
    Console.WriteLine($"{number} -> {FindSecondNum(number)}");
}
else
{
    Console.WriteLine("Введите корректное трехзначное число!");
}
