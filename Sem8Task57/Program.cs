// Задача №57
// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается
// элемент входных данных.

// Метод печати одномерного массива
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i] + ", ");
        Console.Write(arr[arr.Length-1]);
    }
    Console.Write("]");
}

// Метод запроса данных у пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
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

// Метод построения частотного словаря
int[] FreqDicBuild(int[,] arr, int len)
{
    int[] dic = new int[len];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            dic[arr[i, j]]++;
        }
    }
   return dic;
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr = new int[row, column];
Gen2DArr(arr, 0, 9);
Console.WriteLine("Исходный массив:");
Print2DArr(arr);
Console.WriteLine();
int[] Arr = FreqDicBuild(arr, 10);
Console.WriteLine("Измененный массив:");
Print1DArr(Arr);