// Задача №53
// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю
// строку массива.

Console.Clear();

// Метод запроса данных у пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
// Метод генерации двумерного массива
void Gen2DArr(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

// Метод печати двумерного массива
void Print2DArr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// 2 0 0 0
// 1 1 1 1 temp
// 0 2 2 2
void Change2DArr(int[,] matr)
{
    int temp = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        temp = matr[0, i];
        matr[0, i] = matr[matr.GetLength(0) - 1, i];
        matr[matr.GetLength(0) - 1, i] = temp;
    }
}

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matr = new int[m, n];
Gen2DArr(matr, 1, 100);
Console.WriteLine("Исходный массив:");
Print2DArr(matr);
Change2DArr(matr);
Console.WriteLine("Измененный массив:");
Print2DArr(matr);
