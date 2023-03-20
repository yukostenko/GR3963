// Задача №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод выводит данные от пользователя
void PrintData(string msg, int val)
{
    Console.WriteLine(msg + val);
}

// Метод поиска точки пересения двух прямых
int Intersection2Lines(int b1, int b2, int k1, int k2)
{
    int y = k1 * x + b1;
    int y = k2 * x + b2;
}

int b1 = ReadData("Введите значение b1: ");
int b2 = ReadData("Введите значение b2: ");
int k1 = ReadData("Введите значение k1: ");
int k2 = ReadData("Введите значение k2: ");

int res = Intersection2Lines(b1, b2, k1, k2);

PrintData("Координаты точки пересечения двух прямых: ", res);
