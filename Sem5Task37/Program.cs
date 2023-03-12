// Задача №37
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// Например:
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

//
int [] ConvertArr(int [] arr)
{
    int [] bufArr = new int [(arr.Length/2)+1];
    for (int i = 0; i < (arr.Length/2)+1; i++)
    {
        bufArr[i] = arr [i]*arr[arr.Length-1-i];
    }
    return bufArr;
}


int[] testArr = Gen1DArr(5,-10,10);
Print1DArr(testArr);
Print1DArr(ConvertArr(testArr));