// Написать программу,
// 1. которая по заданному номеру четверти, 
// 2. показывает диапозон возможных координат точек в этой четверти.


Console.WriteLine("Введите номер четверти на плоскости от 1 до 4: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string range = Range(quarter);
Console.WriteLine(range);


string Range(int quarterNum)
{
    if (quarterNum == 1) return $"Четверти {quarterNum} соответствуют координаты от x > 0, y > 0";
    if (quarterNum == 2) return $"Четверти {quarterNum} соответствуют координаты от x < 0, y > 0";
    if (quarterNum == 3) return $"Четверти {quarterNum} соответствуют координаты от x < 0, y < 0";
    if (quarterNum == 4) return $"Четверти {quarterNum} соответствуют координаты от x > 0, y < 0";
    return "Введен некорректный номер четверти";
}

