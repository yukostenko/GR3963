// Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в
// случайном порядке.

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

Print1DArr(Gen1DArr(8, 0, 1));