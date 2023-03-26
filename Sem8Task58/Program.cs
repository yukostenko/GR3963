// Задача 58: Задайте две матрицы.
//Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Метод запроса данных у пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
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
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
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

// Метод для умножения массивов
int[,] Multipl2DArr(int[,] arr1, int[,] arr2)
{
    if (arr1.GetLength(1) != arr2.GetLength(0))
    {
        Console.WriteLine("Умножение не возможно! Количество столбцов массива 1 не равно количеству строк массива 2.");
    }

    int [,] resArr = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            resArr[i, j] = 0;

            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                resArr[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }

    return resArr;
}

int n1 = ReadData("Введите количество строк массива 1: ");
int m1 = ReadData("Введите количество столбцов массива 1: ");
int n2 = ReadData("Введите количество строк массива 2: ");
int m2 = ReadData("Введите количество столбцов массива 2: ");
int[,] arr2D1 = Gen2DArr(n1, m1, 0, 9);
int[,] arr2D2 = Gen2DArr(n2, m2, 0, 9);
Console.WriteLine("Исходный массив 1: ");
Print2DArr(arr2D1);
Console.WriteLine("Исходный массив 2: ");
Print2DArr(arr2D2);
int[,] arr2Dres = Multipl2DArr(arr2D1, arr2D2);
Console.WriteLine("Результат умножения массивов: ");
Print2DArr(arr2Dres);