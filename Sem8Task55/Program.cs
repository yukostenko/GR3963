// Задача №55
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести
// сообщение для пользователя (транспонирование для квадратной матрицы).

// Метод запроса данных у пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод генерации двумерного массива
void Gen2DArr(int[,] matr, int min, int max)
{
    // Блок корректировки входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
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
// Метод транспонирования матрицы
void TrancpArr(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        };

    }
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr = new int[row, column];
Gen2DArr(arr, 1, 100);
Print2DArr(arr);
if (arr.GetLength(0) == arr.GetLength(1))
{
    TrancpArr(arr);
    Print2DArr(arr);
    }
else
{
    Console.WriteLine("Матрица не квадратная!");
}



