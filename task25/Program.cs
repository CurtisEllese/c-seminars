// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int firstNum = EnterDigit("Введите первое число: ");
int secondNum = EnterDigit("Введите натуральное число: ");

while (secondNum < 1)
{
    secondNum = EnterDigit("Введите положительное, целое число верно: ");
}

int numInPower = GetNumInPower(firstNum, secondNum);
Console.WriteLine($"{firstNum}, {secondNum} -> {numInPower}");

int GetNumInPower(int number1, int number2)
{
    int result = 1;
    for (int i = 1; i <= number2; i++)
    {
        result *= number1;
    }
    return result;
}

int EnterDigit(string text)
{
    Console.Write(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}