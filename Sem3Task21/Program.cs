// Задача №21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

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
double CalcLength3D (int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
}

int x1 = ReadData("Введите координату x точки A: ");
int y1 = ReadData("Введите координату y точки A: ");
int z1 = ReadData("Введите координату z точки A: ");
int x2 = ReadData("Введите координату x точки B: ");
int y2 = ReadData("Введите координату y точки B: ");
int z2 = ReadData("Введите координату z точки B: ");


double res = CalcLength3D(x1,y1,x2,y2,z1,z2);

PrintData ("Расстояние между точками A и B: ", res);