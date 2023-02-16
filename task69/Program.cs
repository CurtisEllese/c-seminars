// Задача 69: 
// 1. Напишите программу, которая на вход принимает два числа A и B, и
// 2. возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int numberA = GetEnteredNumber("Введите первое число: ");
int numberB = GetEnteredNumber("Введите второе число: ");

int aInPowerB = GetAToPowerOfB(numberA, Math.Abs(numberB));
Console.WriteLine(numberB > 0 ? $"Степень = {aInPowerB}" : $"Степень = 1/{aInPowerB}");

int GetAToPowerOfB(int a, int b)
{
    if (b == 0) return 1;
    else return a * GetAToPowerOfB(a, b - 1);
}

int GetEnteredNumber(string text)
{
    Console.Write(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}