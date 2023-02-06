// Задача 43: Напишите программу, которая 
// 1. найдёт точку пересечения двух прямых, 
// 2. заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// 3. значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double k1 = GetEnteredNum("Введите значение k1: ");
double b1 = GetEnteredNum("Введите значение b1: ");

double k2 = GetEnteredNum("Введите значение k2: ");
double b2 = GetEnteredNum("Введите значение b2: ");

(double, double) intersectionPoint = GetIntersectionPoint(k1, b1, k2, b2);

Console.WriteLine($"Точка пересечения -> {intersectionPoint}");

(double, double) GetIntersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 1);
    double y = Math.Round(k1 * x + b1, 1);
    (double, double) result = (x, y);
    return result;
}

int GetEnteredNum(string text)
{
    Console.Write(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}