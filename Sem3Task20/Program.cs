// Задача №20
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// Например:
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод выводит данные от пользователя
void PrintData(string msg, double val)
{
    Console.WriteLine(msg+val);
}

// Метод выводит расстояние между точками на плоскости
double CalcLength2D (int x1, int x2, int y1, int y2)
{
    return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
}

int x1 = ReadData("Введите координату x точки A: ");
int y1 = ReadData("Введите координату y точки A: ");
int x2 = ReadData("Введите координату x точки B: ");
int y2 = ReadData("Введите координату y точки B: ");

double res = CalcLength2D(x1,y1,x2,y2);

PrintData ("Расстояние между точками A и B: ", res);