// Задача №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

// Метод читает данные от пользователя
double ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод выводит данные от пользователя
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Метод поиска точки пересения двух прямых
(double x, double y) Intersection2Lines (double b1, double b2, double k1, double k2)
{
    double X1 = (b2 - b1) / (k1 - k2);
    double Y1 = (k1 * b2 - k2 * b1) / (k1 - k2);
    return (X1, Y1);
}

double b1 = ReadData("Введите значение b1: ");
double b2 = ReadData("Введите значение b2: ");
double k1 = ReadData("Введите значение k1: ");
double k2 = ReadData("Введите значение k2: ");

(double x, double y) point = Intersection2Lines(b1, b2, k1, k2);

double X1 = point.x;
double Y1 = point.y;

PrintData($"Координаты точки пересечения двух прямых: X1 = {X1}; Y1 = {Y1};");
