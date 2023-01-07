// Написать программу, которая
// 1. принимает на вход любое целое число и 
// 2. выводит третью цифру заданного числа или
// 3. сообщает, что третьей цифры нет

// 645 - 5
// 78 - третьей цифры нет
// 153535 - 3

Console.WriteLine("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int GetThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    num = num % 10;
    return num;
}

if (number < 100)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else
{
    Console.WriteLine($"{number} -> {GetThirdDigit(number)}");
}

