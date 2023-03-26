// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Метод запроса данных у пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
// Метод генерации трехмерного массива
int[,,] Gen3DArr(int x, int y, int z, int minValue, int maxValue)
{
    // Блок корректировки входных данных
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }
    int[,,] arr = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                arr[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }

        }
    }
    return arr;
}
// Метод печати трехмерного массива
void Print3DArr(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k})"+"\t");
            }
            Console.WriteLine();
        }
    }
}

int x = ReadData("Введите размер 1 массива: ");
int y = ReadData("Введите размер 2 массива: ");
int z = ReadData("Введите размер 3 массива: ");
int[,,] arr3D = Gen3DArr(x, y, z, 10, 99);
Console.WriteLine("Полученный массив: ");
Print3DArr(arr3D);
