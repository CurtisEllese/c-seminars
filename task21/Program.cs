// Напишите программу, которая 
// 1. принимает на вход координаты двух точек и 
// 2. находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

string firstPoint = $"A({x1}, {y1}, {z1})";
string secondPoint = $"B({x2}, {y2}, {z2})";
string distanceOfTwoPoints  = $"{firstPoint}; {secondPoint} -> {DistanceOfTwoPoints(x1, y1, z1, x2, y2, z2)}";
Console.WriteLine(distanceOfTwoPoints);


double DistanceOfTwoPoints(int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    double power1 = Math.Pow((xc2 - xc1), 2);
    double power2 = Math.Pow((yc2 - yc1), 2);
    double power3 = Math.Pow((zc2 - zc1), 2);
    double sum = power1 + power2 + power3;
    double sqrt = Math.Sqrt(sum);
    double result = Math.Round(sqrt, 2, MidpointRounding.ToZero);
    return result;
}