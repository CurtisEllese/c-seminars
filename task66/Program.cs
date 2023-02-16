// Задача 66: 
// 1. Задайте значения M и N. 
// 2. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int number1 = GetEnteredNumber("Введите первое число: ");
int number2 = GetEnteredNumber("Введите второе число: ");

int sum = SumOfNaturalsRecoursive(number1, number2);
Console.WriteLine($"M = {number1}; N = {number2} -> {sum}");

int SumOfNaturalsRecoursive(int num1, int num2)
{
    int result = 0;
    if (num2 == num1) return num2;
    if (num2 > num1) return SumOfNaturalsRecoursive(num1, num2 - 1) + result + num2;
    else return SumOfNaturalsRecoursive(num1 - 1, num2) + result + num1;
}

int GetEnteredNumber(string text)
{
    Console.Write(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}