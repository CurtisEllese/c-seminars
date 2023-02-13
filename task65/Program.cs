// Задача 65: 
// 1. Задайте значения M и N. 
// 2. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int number1 = EnterNumber("Введите первое число: ");
int number2 = EnterNumber("Введите второе число: ");

if (number1 < number2) PrintNumsInIntervalAsc(number1, number2);
if (number1 > number2) PrintNumsInIntervalDesc(number1, number2);

void PrintNumsInIntervalDesc(int m, int n)
{
    if (m < n) return;
    PrintNumsInIntervalDesc(m, n + 1);
    Console.Write($"{n} ");
}

void PrintNumsInIntervalAsc(int m, int n)
{
    if (n < m) return;
    PrintNumsInIntervalAsc(m, n - 1);
    Console.Write($"{n} ");
}

int EnterNumber(string text)
{
    Console.Write(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// void PrintNumsInInterval(int m, int n)
// {
//     if (n == m)
//     {
//         Console.Write($"{m} ");
//         return;
//     }

//     if (n > m) 
//     {
//     PrintNumsInInterval(m, n - 1);
//     }
//     else
//     {
//         PrintNumsInInterval(m, n + 1);
//     }
//     Console.Write($"{n} ");
// }