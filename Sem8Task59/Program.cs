// Задача №59
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен
// наименьший элемент массива.

// Метод запроса данных у пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод генерации двумерного массива
void Gen2DArr(int[,] arr, int min, int max)
{
    // Блок корректировки входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

// Метод печати двумерного массива
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Update2DArr(int[,] arr, int x, int y)

{
    int[,] res = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int k = 0; int m = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        m = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != y && i != x)
            {
                res[k, m] = arr[i, j];
            }
            if (j != x) m++;
        }
        if (i != x) k++;
    }
    return res;
}

(int x, int y) SearchMinElementIn2DArr(int[,] arr)
{
    int row = 0;
    int col = 0;
    int min = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                row = i;
                col = j;
            }
        }
    }
    return (row, col);
}

int m = ReadData("Введите количество строк: ");
int n = ReadData("Введите количество столбцов: ");
int[,] arr = new int[m, n];
Gen2DArr(arr, 0, 100);
Console.WriteLine("Исходный массив:");
Print2DArr(arr);
(int x, int y) minElem = SearchMinElementIn2DArr(arr);
int[,] outArr = Update2DArr(arr, minElem.x, minElem.y);
Console.WriteLine("Измененный массив:");
Print2DArr(outArr);
