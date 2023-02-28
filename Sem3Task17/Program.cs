// Задача №17
// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой находится эта точка.

// <тип> <имя метода> (<тип> <название переменной>) // имена методов даем сами
// {
//     return <тип>
// }

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод определяет четверть по координатам точки
void PrintQuaterTest(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Точка в 1 четверти");
    if (x > 0 && y < 0) Console.WriteLine("Точка во 2 четверти");
    if (x < 0 && y < 0) Console.WriteLine("Точка в 3 четверти");
    if (x < 0 && y > 0) Console.WriteLine("Точка в 4 четверти");
}

int X = ReadData("Введите координату Х: ");
int Y = ReadData("Введите координату Y: ");
PrintQuaterTest(X, Y);