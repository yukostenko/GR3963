// Задача №41 Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// *

// метод запрашивает и считывает данные с консоли

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Вывод полученных данных
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Метод подсчета положительных чисел, которые ввел пользователь
int CountNum(int numN)
{
  int res = 0;
  for (int i = 0; i < numN; i++)
  {
     if (ReadData(" ") > 0)
     res++;
  }
  return res;
}

int numN = ReadData("Введите число: ");
int res = CountNum(numN);
PrintData(res.ToString());
