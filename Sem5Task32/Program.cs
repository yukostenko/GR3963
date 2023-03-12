// Задача №32
// Напишите программу замены элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// Пример:
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

// Метод замены элементов массива
void InversArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        arr[i] = arr[i] * (-1);
    }
}

int[] testArr = Gen1DArr(4,-4,4);
Print1DArr(testArr);
InversArr(testArr);
Print1DArr(testArr);
