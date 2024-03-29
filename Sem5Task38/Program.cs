﻿// Задача №38 Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6

// Метод генерации одномерного массива вещественных чисел
double[] Gen1DArr(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(rnd.Next(minValue, maxValue) / 10.0);
        //arr[i] = new Random().Next(minValue, maxValue+1)+(new Random().NextDouble());
        //arr[i] = Math.Round(arr[i],4);
    }
    return arr;
}

// Метод печати одномерного массива вещественных чисел
void PrintGen1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Сортировка методом пузырька
void BubbleSort(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                double buf = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = buf;
            }
        }
}

//Метод нахождения разницы между максимальным и минимальным значениями
//элементов массива
// double[] MaxMin(double[] arr)
// {
//     double res = 0;
//     double min = double.MaxValue;
//     double max = double.MinValue;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > max) max = arr[i];
//         if (arr[i] > min) min = arr[i];
//         res = res + (max - min);
//     }
//     return res;
// }

// Вывод полученных данных
// void PrintData(string msg, double num)
// {
//     Console.WriteLine(msg + num);
// }

double[] testArr = Gen1DArr(20, -15, 15);
PrintGen1DArr(testArr);
BubbleSort(testArr);
PrintGen1DArr(testArr);
//PrintData("Разница между максимальным и минимальным значениями массива равна: ", MaxMin(testArr));
Console.WriteLine(testArr[testArr.Length-1]-testArr[0]);//в скобках - последний элемент массива минус первый элемент массива