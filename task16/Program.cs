// Написать программу, которая
// 1. принимает на вход два числа и 
// 2. проверяет, является ли одно число квадратом другого.

// 5, 25 - да
// -4, 16 - да
// 25, 5 - да
// 8, 9 - нет

Console.WriteLine("Введите первое целое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool IsSquareOfNumber(int number1, int number2)
{
    return number1 * number1 == number2 || number2 * number2 == number1;
}

if (IsSquareOfNumber(firstNumber, secondNumber))
{
    Console.WriteLine($"{firstNumber}, {secondNumber} -> да");
}
else
{
    Console.WriteLine($"{firstNumber}, {secondNumber} -> нет");
}