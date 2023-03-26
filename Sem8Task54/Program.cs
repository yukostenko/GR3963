// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.

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
// Метод упорядочивания элементов каждой строки двумерного массива
// по убыванию
void Sort2DArr(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(1) - 1; k++)
      {
        if (arr[i, k] < arr[i, k + 1])
        {
          int temp = arr[i, k + 1];
          arr[i, k + 1] = arr[i, k];
          arr[i, k] = temp;
        }
      }
    }
  }
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2DArr(row, column, 0, 99);
Console.WriteLine("Исходный массив: ");
Print2DArr(arr2D);
Sort2DArr(arr2D);
Console.WriteLine("Измененный массив: ");
Print2DArr(arr2D);
