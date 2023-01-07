// Написать программу, которая 
// 1. будет принимать на вход два числа и 
// 2. выводить, является ли первое число кратным второму.
// 3. Если первое число не кратно второму, то программа выводит остаток от деления

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое целое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

void CheckMultiplicity(int number1,int number2)
{
    if (number1 / number2 == number2)
    {
        Console.WriteLine($"Число {number1} кратно числу {number2}");
    }
    else
    {
        int modulo = number1 % number2;
        Console.WriteLine($"Число {number1} не кратно числу {number2}. Остаток от деления - {modulo}");
    }
}

CheckMultiplicity(firstNumber, secondNumber);
