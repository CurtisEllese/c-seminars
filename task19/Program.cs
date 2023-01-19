// Написать программу, которая
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.

// 14212 - нет
// 23432 - да
// 12821 - да

// сделать переворот числа и прверку

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int newNumber = 0;

bool IsPalindromic(int num)
{
    int temp = num;
    while (num > 0)
    {
        int lastDigit = num % 10;
        num = num / 10;
        newNumber = Convert.ToInt32($"{newNumber}{lastDigit}");
    }
    return newNumber == temp;
}

if (IsPalindromic(number)) 
{
    Console.Write($"{number} - да");
}
else
{
    Console.Write($"{number} - нет");
}