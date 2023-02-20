// Задача 68: 
// 1. Даны два неотрицательных числа m и n.
// 2. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int number1 = GetEnteredNumber("Введите первое целое, положительное число: ");
int number2 = GetEnteredNumber("Введите второе целое, положительное число: ");

while (number1 < 0 || number2 < 0)
{
    if (number1 < 0)
    {
        number1 = GetEnteredNumber("Введите первое целое, положительное число верно: ");
    }
    if (number2 < 0)
    {
        number2 = GetEnteredNumber("Введите второе целое, положительное число верно: ");
    }
}

int result = AckermannFunction(number1, number2);
System.Console.WriteLine(result);
int AckermannFunction(int m, int n)
{
    if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    if (m == 0) return n + 1;
    else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

int GetEnteredNumber(string text)
{
    Console.Write(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}