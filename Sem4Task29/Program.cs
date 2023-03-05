// Задача №29 Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементов.

// Запрос данных у пользователя
int ReadData(string msg)
{
    // Выводим сообщение
    Console.WriteLine(msg);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод печати одномерного массива
void Print1DArr(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length-1; i++)
  {
    Console.Write(arr[i] + ", ");
    Console.Write(arr[arr.Length-1]);
  }
  Console.Write("]");
}

// Метод генерации одномерного массива
int[] Gen1DArr(int len, int min, int max)
{
 // создаем массив
 int[]arr = new int[len];
 // заполняем массив
 for (int i = 0; i < len; i++) 
 {
   arr[i] = new Random().Next(min, max+1);
 }
 return arr;
}

int len = ReadData("Введите длину массива: ");
int min = ReadData("Введите минимальное значение элемента массива: " );
int max = ReadData("Введите максимальное значение элемента массива: ");

int[] res = Gen1DArr(len, min, max);
Print1DArr(res);