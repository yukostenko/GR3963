// Задание №52 Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом
// столбце.

Console.Clear();
// Генерация двумерного массива
int[,] Gen2DArr(int RowCount, int ColCount, int min, int max)
{
    {
        int buf;
        if (min > max)
        {
            buf = min;
            min = max;
            max = buf;
        }
    }
    int[,] binarray = new int[RowCount, ColCount];
    System.Random numSintezator = new System.Random();
    for (int i = 0; i < RowCount; i++)
    {
        for (int j = 0; j < ColCount; j++)
        {

            binarray[i, j] = numSintezator.Next(min, max);

        }
    }
    return binarray;
}

//Печать 2-х мерного массива
void Print2DArry(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write($"{array[i, j]}\t");

        }
        Console.WriteLine();
    }
}

//Печать одномерного массива
void Print1DArry(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]}\t");
    }

}
//подсчет среднего арифметического столбцов
double[] AverageCol(int[,] arr)
{
    double[] result = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            result[i] += arr[j, i];
        }
        result[i] = Math.Round(result[i] / (arr.GetLength(0)), 2);
    }

    return result;
}

int[,] array = Gen2DArr(20, 100, 6, 7);
Console.WriteLine("Исходный массив:");
Print2DArry(array);

Console.WriteLine("Среднее арифметическое каждого столбца:");
double[] result = AverageCol(array);
Print1DArry(result);
