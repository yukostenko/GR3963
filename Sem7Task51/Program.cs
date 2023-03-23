// Задача №51
// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с
// индексами (0,0); (1;1) и т.д.
// Например:
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Метод запроса данных у пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод выводит данные от пользователя
void PrintData(string msg, int print)
{
    Console.WriteLine(msg+print);
}

// Метод генерации двумерного массива
int[,] Gen2DArr(int countRow, int countColumn, int minValue, int maxValue)
{
    // Блок корректировки входных данных
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }
    Random rnd = new Random();
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return arr;
}

// Метод печати двумерного массива
void Print2DArr(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,
    ConsoleColor.Cyan,ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
    ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
    };

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 9)];
            Console.Write(arr[i, j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();

    }
}

// Метод определения суммы элементов главной диагонали
int CountMainDiag(int[,] arr)
{
    int res = 0;
    int min = arr.GetLength(0)>arr.GetLength(1)? arr.GetLength(1): arr.GetLength(0);
    for (int j = 0; j < min; j++)
    {
        res = res + arr[j, j];
    }
    return res;
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2DArr(row, column, 10, 99);
Console.WriteLine("Исходный массив: ");
Print2DArr(arr2D);
PrintData("Сумма элементов главной диагонали: ", CountMainDiag(arr2D));
