// Задача №35
// Задайте одномерный массив из 123 случайных
// чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].
// Например:
// Пример для массива из 5, а не 123 элементов. В
// своем решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


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

// Метод поиска элементов в массиве в заданном отрезке
int NumElemInRange(int[] arr, int minValue, int maxValue)
{ 
    int result  = 0;
    for (int i = 0; i < arr.Length; i++)
    {
     if ((arr[i] > minValue) && (arr[i] < maxValue))
     {
         result++;
     }
    }
    return result;
}

int[] testArr = Gen1DArr(123,-50,50);
Print1DArr(testArr);
PrintData("Количество элементов в массиве: ", NumElemInRange(testArr, 10, 99));
// PrintData($"{NumElemInRange(testArr, 10, 99)}");
