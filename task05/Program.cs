// Написать программу, которая 
// 1. на вход принимает одно число(N), а 
// 2. на выходе показывает все целые числа в промежутке от -N до N

Console.Write("Введите любое целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = -(N);

while (count <= N)
{
    Console.WriteLine(N);
    N -= 1;
};
