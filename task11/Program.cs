// Написать программу, которая 
// 1. Выводит случайное трехзначное число и 
// 2. Удаляет вторую цифру этого числа и 
// 3. выводит получившееся число

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное целое трехзначное число - {number}");

int GetTwoDigitNumber(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int newNumber = Convert.ToInt32($"{firstDigit}{thirdDigit}");

    return newNumber;
}

int twoDigitNumber = GetTwoDigitNumber(number);
Console.WriteLine($"Новое число - {twoDigitNumber}");