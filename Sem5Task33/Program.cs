// Задача №33
// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в
// массиве.
// Например:
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

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

// Метод поиска элемента массива
int SearchElement(int[] arr, int elm)
{
    int res = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elm)
        {
            res = i; break;
        }
    }
    return res;
}

int[] testArr = Gen1DArr(4,-4,4);
Print1DArr(testArr);
int elm = ReadData("Введите число для поиска в массиве: ");
int srchElm = SearchElement(testArr, elm);

if (srchElm > 0)
{
  Console.WriteLine("Искомый элемент находится в массиве с индексом: " + srchElm);
}
else
{
  Console.WriteLine("Искомый элемент в массиве отсутсвует ");
}


