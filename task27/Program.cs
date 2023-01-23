// Задача 27: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = EnterNumber("Введите число: ");

int sumOfDigits = TransformateNegativeNum(number);

Console.WriteLine($"Сумма цифр числа {number} = {sumOfDigits}");

int TransformateNegativeNum(int num)
{
    int sumOfDigits = 0;
    if (num < 0) 
    {
        sumOfDigits = SumOfDigits(num * -1);
    }
    else
    {
        sumOfDigits = SumOfDigits(num);
    }
    return sumOfDigits;
}

int SumOfDigits(int num)
{
    int result = 0;
    for (int i = 0; i <= num; i++)
    {
        int temp = num % 10;
        result += temp;
        num = num / 10; 
    }

    return result;
}

int EnterNumber(string text)
{
    Console.Write(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}