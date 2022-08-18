double x1 = Coordinate("x", "A");
double y1 = Coordinate("y", "A");
double z1 = Coordinate("z", "A");
double x2 = Coordinate("x", "B");
double y2 = Coordinate("y", "B");
double z2 = Coordinate("z", "B");

double Coordinate(string c, string p)
{
    Console.Write($"Введите координату {c} точки {p}: ");
    return double.Parse(Console.ReadLine());
}

double Set (double x1, double x2, 
                double y1, double y2, 
                double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) +               // Math.Sqrt извлекает квадратный корень
                   Math.Pow((y2-y1), 2) +               // Math.Pow возводит в степень
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round ( Set (x1, x2, y1, y2, z1, z2), 1 ); // Math.Round округляет до выбранного количества знаков

Console.WriteLine($"Длина отрезка  {segmentLength}");