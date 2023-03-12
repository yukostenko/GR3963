// Задача №31
// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных
// элементов массива.

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

//Вывод двух переменных из метода (1)
(int positiv, int negativ) NegPosSum(int[] arr)
{
    int positivSum = 0;
    int negativSum = 0;

    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        if (arr[i] > 0)
        {
            positivSum += arr[i];
        }
        else
        {
            negativSum += arr[i];
        }
    }
    return (positivSum, negativSum);
}

//Вывод двух переменных из метода (2)
// int[] NegPosSum2(int[] arr)
// {
//     int positivSum = 0;
//     int negativSum = 0;

//     int len = arr.Length;
//     for (int i = 0; i < len; i++)
//     {
//         if (arr[i] > 0)
//         {
//             positivSum += arr[i];
//         }
//         else
//         {
//             negativSum += arr[i];
//         }
//     }
//     int[] outArr = new int[2];
//     outArr[0] = positivSum;
//     outArr[1] = negativSum;
//     return (outArr);
// }

// Печать полученных сумм (результат)
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

int[] testArr = Gen1DArr(12, -9, 9);
Print1DArr(testArr);
DateTime d1 = DateTime.Now;
(int positiv, int negativ) results = NegPosSum(testArr);
//int[] res = NegPosSum2(testArr);
Console.WriteLine(DateTime.Now - d1);
PrintData("Сумма положительных чисел в массиве: ", results.positiv);
PrintData("Сумма отрицательных чисел в массиве: ", results.negativ);
//PrintData("Сумма положительных чисел в массиве: ", res[0]);
//PrintData("Сумма отрицательных чисел в массиве: ", res[1]);

