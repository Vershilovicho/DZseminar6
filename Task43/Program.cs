// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double PointXCoordinate(double kk1, double bb1, double kk2, double bb2)
{
    double x1 = default;
    x1 = (bb2 - bb1) / (kk1 - kk2);
    x1 = Math.Round(x1, 1);
    return x1;
}

double PointYCoordinate(double kk1, double bb1, double kk2, double bb2)
{
    double y1 = default;
    y1 = kk1 * ((bb2 - bb1) / (kk1 - kk2)) + bb1;
    y1 = Math.Round(y1, 1);
    return y1;

}


if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают");
}
else
{
    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        double x = PointXCoordinate(k1, b1, k2, b2);
        double y = PointYCoordinate(k1, b1, k2, b2);
        Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y})");
    }

}

