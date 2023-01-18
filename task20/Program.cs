// Написать программу, которая
// 1. на вход принимает координаты двух точек и 
// 2. находит расстояние между ними в 2Д пространстве.

// А(3, 6); В(2, 1) -> 5, 09
// A(7, -5); B(1, -1) -> 7, 21

Console.WriteLine("Введите координаты первой точки");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

string firstPoint = $"A({x1}, {y1})";
string secondPoint = $"B({x2}, {y2})";
string distanceOfTwoPoints  = $"{firstPoint}; {secondPoint} -> {DistanceOfTwoPoints(x1, y1, x2, y2)}";
Console.WriteLine(distanceOfTwoPoints);


double DistanceOfTwoPoints(int xc1, int yc1, int xc2, int yc2)
{
    double power1 = Math.Pow((xc2 - xc1), 2);
    double power2 = Math.Pow((yc2 - yc1), 2);
    double sum = power1 + power2;
    double sqrt = Math.Sqrt(sum);
    double result = Math.Round(sqrt, 2, MidpointRounding.ToZero);
    return result;
}
