// Написать программу, которая
// 1. принимает на вход три числа и
// 2. проверяет, может ли существовать треугольник со сторонами такой длины.

// (каждая сторона треугольника меньше суммы 2-х других)

Console.Write("Введите длину первой стороны треугольника: ");
int sideA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину второй стороны треугольника: ");
int sideB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину третьей стороны треугольника: ");
int sideC = Convert.ToInt32(Console.ReadLine());

if (CheckTriangleSides(sideA, sideB, sideC))
{
    Console.WriteLine("Такой треугольник существует");
}
else
{
    Console.WriteLine("Такой треугольник не существует");
}

bool CheckTriangleSides(int side1, int side2, int side3)
{
    return side1 + side2 > side3 && side1 + side3 > side2 && side3 + side2 > side1;
}