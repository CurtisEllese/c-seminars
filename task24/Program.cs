// Написать программу, которая
// 1. принимает на вход число А и 
// 2. выдает сумму чисел от 1 до А

// 7 - 28
// 4 - 10
// 8 - 36

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// int number = int.Parse(Console.ReadLine());
int sumOfNumbers = SumOfNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} -> {sumOfNumbers}");

int SumOfNumbers(int num)
{
    int sum = 0;
        for (int i = 1; i <= num; i++)
        {
            sum += i;        
        }
    return sum;
}