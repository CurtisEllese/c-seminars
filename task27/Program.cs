// Задача 27: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = EnterNumber("Введите число: ");

int sumOfDigits = SumOfDigits(number);

Console.WriteLine($"Сумма цифр числа {number} = {sumOfDigits}");

int TransformateNegativeNum(int num)
{
    if (num < 0) num *= -1;
    return num;
}

int SumOfDigits(int num)
{
    num = TransformateNegativeNum(num);
    int result = 0;
    for (int i = num; i > 0; i--)
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