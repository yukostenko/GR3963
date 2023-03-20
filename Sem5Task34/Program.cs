// Задача №34 Задайте массив заполненный случайными
// положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1


// Метод генерации одномерного массива
// int[] Gen1DArr(int len, int num)
// {
//     Random rnd = new Random();
//     int[] arr = new int[len];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(99, 999);
//     }
//     return arr;
// }
// Метод печати одномерного массива
// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + "\t");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }

// Метод поиска четных чисел в массиве
// int CountEvenElement(int[] arr)
// {
//     int res = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             res++;
//         }
//     }
//     return res;
// }

// int[] testArr = Gen1DArr(5, 456);
// Print1DArr(testArr);
// CountEvenElement(testArr);
// Console.WriteLine("Количество четных элементов в массиве равно: ", CountEvenElement(testArr));

//Метод, генерирующий массив
int[] Gen1DArr(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}

// Метод, выводящий на печать данные пользователя
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод печати одномерного массива
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Метод поиска четных чисел в массиве
int CountEvenElement(int[] arr)
{
    int res = 0;
    int i = 0;
    while (i < arr.Length - 1)
    {
        if (arr[i] % 2 == 0)
        {
            res++;
        }
        i++;
    }
    return res;
}

// Сортировка методом пузырька
void BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int buf = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = buf;
            }
        }
}


int[] testArr = Gen1DArr(20, 100, 999);
BubbleSort(testArr);
Print1DArr(testArr);
int result = CountEvenElement(testArr);
PrintData(result.ToString());
