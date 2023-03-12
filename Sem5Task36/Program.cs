// Задача №36 Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю

// Метод генерации одномерного массива
int[] Gen1DArr(int len, int minValue, int maxValue)
{
    // Блок корректировки входных данных
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }

    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue + 1);
    }
    return arr;
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

// Вывод полученных данных
void PrintData(string msg, int num)
{
    Console.WriteLine(msg + num);
}

// Метод поиска суммы элементов, стоящих на нечетных позициях.
int OddSum(int[] arr)
{
    int res = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        res = res + arr[i];
    }
    return res;
}

int[] testArr = Gen1DArr(10,-5,5);
Print1DArr(testArr);
PrintData("Сумма элементов, стоящих на нечетных позициях: ", OddSum(testArr));