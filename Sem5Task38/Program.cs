// Задача №38 Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами.

// Метод генерации одномерного массива вещественных чисел
double[] Gen1DArr(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(rnd.Next(minValue, maxValue) / 10.0);
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

//Метод нахождения разницы между максимальным и минимальным значениями
//элементов массива
double[] MaxMin(double[] arr)
{
    double res = 0;
    double min = double.MaxValue;
    double max = double.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] > min) min = arr[i];
        res = res + (max - min);
    }
    return res;
}

// Вывод полученных данных
void PrintData(string msg, double num)
{
    Console.WriteLine(msg + num);
}

double[] testArr = Gen1DArr(10, -5, 5);
PrintGen1DArr(testArr);
PrintData("Разница между максимальным и минимальным значениями массива равна: ", MaxMin(testArr));
