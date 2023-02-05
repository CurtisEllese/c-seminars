// Написать программу, которая будет
// 1. принимать десятичное число на вход и 
// 2. преобразовывать десятичное число в двоичное

// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int binaryNumber = Convert.ToInt32(ConvertDecToBinary(number));

Console.WriteLine($"{number} -> {binaryNumber}");


string ConvertDecToBinary(int num)
{
    string result = String.Empty;
    if (num == 0) return result = "0";

    while (num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    return result;
}




// string ConvertDecToBinary(int num)
// {
//     string result = String.Empty;
//     if (num == 0) return result = "0";

//     while (num > 0)
//     {
//         result += Convert.ToString(num % 2);
//         num /= 2;
//     }
//     result = ReverseString(result);
//     return result;
// }

// string ReverseString(string str)
// {
//     string reverseString = String.Empty;
//     for (int i = str.Length - 1; i >= 0; i--)
//     {
//         reverseString += str[i];
//     }
//     return reverseString;
// }





// int ConvertDecToBinary(int num)
// {
//     if (num == 0) return 0;
//     int result = num  % 2;
//     num /= 2;
//     result += ConvertDecToBinary(num) * 10;
//     return result;
// }