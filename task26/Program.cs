// Написать программу, которая
// 1. Принимает на вход число и 
// 2. выдоет количество цифп в числе

// 456 - 3
// 78 - 2
// 89126 - 5

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int getAmountOfNum = GetAmountOfNum(number);
Console.WriteLine($"{number} -> {getAmountOfNum}");

int GetAmountOfNum(int num)
{
    int i = 0;
    while (num != 0)
    {
        num = num / 10;
        i++;
    }
    return i;
}