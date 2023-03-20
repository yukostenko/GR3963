// Задача №45
// Напишите программу, которая будет создавать
// копию заданного одномерного массива с помощью
// поэлементного копирования.

// Запрос данных у пользователя
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// Метод, генерирующий массив
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
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
int [] CopyArrayStandartTools(int[] inputArr)
{
   int [] outArr = new int [inputArr.Length];
   inputArr.CopyTo(outArr,0);
   return outArr;
}

// Вывод полученных данных
// void PrintData(string msg)
// {
//     Console.WriteLine(msg);
// }

int[] testArr = Gen1DArr(40, 1, 50);
Print1DArr(testArr);
int[] testArrNew = CopyArrayStandartTools(testArr);
Print1DArr(testArr);
